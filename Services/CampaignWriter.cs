using CampaignSender.Models;

namespace CampaignSender.Services
{
    public class CampaignWriter : ICampaignWriter
    {
        private readonly string? _outputFilePath;
        private readonly ICustomerService _customerService;
        private readonly IConfiguration _cfg;

        public CampaignWriter(IConfiguration cfg, ICustomerService customerService)
        {
            _cfg = cfg;
            _outputFilePath = _cfg["Paths:OutputFile"];
            _customerService = customerService;
        }

        public void WriteCampaignDetailsToFile(Campaign? campaign)
        {
            if (campaign != null)
            {
                var details = $"Campaign ID: {campaign.Id}, Template: {_cfg["Paths:Templates"] + campaign.Template +".html"}, Sending Time: {campaign.SendingTime}, Priority: {campaign.Priority}, Date: {DateTime.UtcNow}";

                WriteToFile(details);
            }
        }

        private void WriteToFile(string content)
        {
            if (_outputFilePath != null)
            {
                File.AppendAllText(_outputFilePath, content + Environment.NewLine);
            }
        }
    }
}
