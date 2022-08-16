namespace FriendOrganiser.DataAccess.Migrations
{
    using FriendOrganiser.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganiser.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganiser.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Thomas", LastName = "Huber" },
                new Friend { FirstName = "Urs", LastName = "Jokoer" });
        }
    }
}
