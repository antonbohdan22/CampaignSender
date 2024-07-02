using Microsoft.EntityFrameworkCore;
using CampaignSender.Models;

namespace CampaignSender.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Gender)
                    .HasColumnType("nvarchar(6)");
            });

            modelBuilder.Entity<Campaign>()
            .HasOne(c => c.CustomerCriteria)
            .WithOne(cc => cc.Campaign)
            .HasForeignKey<CustomerCriteria>(cc => cc.CampaignId);

            modelBuilder.Entity<CustomerCriteria>(entity =>
            {
                entity.Property(e => e.Gender)
                    .HasColumnType("nvarchar(6)");
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CustomerCriteria> CustomerCriterias { get; set; }
    }
}
