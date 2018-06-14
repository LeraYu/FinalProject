namespace TP.Core.Migrations
{
    using TP.Core.json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TP.Core.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TP.Core.Context context)
        {
            RestaurantWriter.Write();
            RestaurantReader.Read();
        }
    }
}
