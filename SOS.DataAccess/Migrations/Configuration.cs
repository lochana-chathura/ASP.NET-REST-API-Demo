namespace SOS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SOS.DataAccess.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<SOS.DataAccess.Data.MainDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SOS.DataAccess.Data.MainDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Projects.AddOrUpdate(x => x.ProjectId,
                new Project() { ProjectId = 1, ProjectName = "QMS" }
            );

            context.Companies.AddOrUpdate(x => x.CompanyId,
                    new Company() { CompanyId = 1, CompanyName = "MIT" }
           );
        }
    }
}
