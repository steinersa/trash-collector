namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrashCollectorProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollectorProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollectorProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Days.AddOrUpdate(
            //      d => d.Name,
            //      new Day { Name = "sunday" },
            //      new Day { Name = "monday" },
            //      new Day { Name = "tuesday" },
            //      new Day { Name = "wednesday" },
            //      new Day { Name = "thursday" },
            //      new Day { Name = "friday" },
            //      new Day { Name = "saturday" }
            //    );
        }
    }
}
