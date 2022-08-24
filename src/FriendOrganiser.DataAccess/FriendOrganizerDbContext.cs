using FriendOrganiser.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FriendOrganiser.DataAccess
{
    public class FriendOrganizerDbContext : DbContext
    {
        public FriendOrganizerDbContext() : base("FriendOrganizerDb")
        {

        }

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Friend>()
                .Property(f=>f.FirstName)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
