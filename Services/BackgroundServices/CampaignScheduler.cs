using CampaignSender.Data;
using CampaignSender.Models;

namespace CampaignSender.Services.BackgroundServices
{
    public class CampaignScheduler : BackgroundService
    {
        private readonly TimeSpan _checkInterval = TimeSpan.FromSeconds(10);
        private readonly IServiceScopeFactory _factory;

        public CampaignScheduler(IServiceScopeFactory factory)
        {
            _factory = factory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                await ScheduledTaskExecution();
                await Task.Delay(_checkInterval, stoppingToken);
            }
        }

        private async Task ScheduledTaskExecution()
        {
            using (var scope = _factory.CreateScope())
            {
                var scopedCustomerService = scope.ServiceProvider.GetRequiredService<ICustomerService>();
                var scopedCampaignService = scope.ServiceProvider.GetRequiredService<ICampaignService>();
                var scopedContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                TimeOnly now = TimeOnly.FromTimeSpan(DateTime.Now.TimeOfDay);
                IList<Campaign> campaigns = scopedContext.Campaigns.ToList();
                foreach (var campaign in campaigns)
                {
                    if (now >= campaign.SendingTime && now <= campaign.SendingTime.Add(_checkInterval))
                    {
                        await scopedCampaignService.SendCampaign(campaign);
                    }

                    if (now.Hour == 0 && now.Minute == 0) await scopedCustomerService.RefreshDailyCampaignsReceivings();
                }
            }
        }

    }
}
