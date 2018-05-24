using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace HairDresserService.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<HairDresserServiceDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HairDresserServiceDataContext context) { }
    }
}
