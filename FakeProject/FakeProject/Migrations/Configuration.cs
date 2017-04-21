namespace FakeProject.Migrations
{
    using FakeProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FakeProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FakeProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.FakeUsers.AddOrUpdate(
              p => p.Name,
              new FakeUser { Name = "Andrew Peters", FakeDate = DateTime.Now.ToString()},
              new FakeUser { Name = "Brice Lambson", FakeDate = DateTime.Now.ToString() },
              new FakeUser { Name = "Rowan Miller", FakeDate = DateTime.Now.ToString() }
            );
            //
        }
    }
}
