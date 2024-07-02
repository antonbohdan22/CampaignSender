using CampaignSender.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CampaignSender.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public int Deposit { get; set; }

        [Required]
        public bool IsANewCustomer { get; set; }
        [Required]
        public bool CampaignReceivedToday { get; set; }
    }
}