using CampaignSender.Models;

namespace CampaignSender.Services
{
    public interface ICampaignWriter
    {
        void WriteCampaignDetailsToFile(Campaign? campaign);
    }
}
