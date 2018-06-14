using TP.Core.transport;
using TP.Core.user;
using System.Data.Entity;
using static TP.Core.transport.Restaurant;
using TP.Core.Migrations;


namespace TP.Core
{
    public class Context : DbContext
    {
        public DbSet<Food> Food { get; set; }

        public DbSet<PathElement> PathElements { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }

        public Context()
            // To specify an explicit connection or DB name call the base class constructor
            : base("localsql")
            //: base("localdb")
        {
            
        }
    }

}
