namespace CampaignSender.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string? Template { get; set; }
        public CustomerCriteria CustomerCriteria { get; set; }
        public TimeOnly SendingTime { get; set; }
        public int Priority { get; set; }
    }
}
