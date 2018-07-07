using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Migrations
{
    class Configuration : DbMigrationsConfiguration<StarCastDBContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StarCastDBContex context)
        {

        }

        public static Configuration Create()
        {
            return new Configuration();
        }
    }
}