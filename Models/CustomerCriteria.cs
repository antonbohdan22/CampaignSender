using CampaignSender.Models.Enums;

namespace CampaignSender.Models
{
    public class CustomerCriteria
    {
        public int Id { get; set; }
        public int? AgeAbove { get; set; }
        public int? AgeBelow { get; set; }
        public Gender? Gender { get; set; }
        public string? City { get; set; }
        public int? DepositAbove { get; set; }
        public int? DepositBelow { get; set; }
        public bool? IsANewCustomer { get; set; }
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
