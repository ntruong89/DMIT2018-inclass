using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eRestaurant.Entities; // Needed for the DbContext base class

namespace eRestaurant.DAL
{
   // Constructor that calls a base-class constructor to specify the 
    // connection string we need to use 
    public class RestaurantContext : DbContext

    {
        public RestaurantContext() : base("name=EatIn") { }

        #region Table to Entity mappings
        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        #endregion



        #region
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables) // r => r.Tabels Identify the naviation property to use
                .WithMany(t => t.Reservations)                // these two lines show how the entities relates
                .Map(mapping =>
                    {
                        mapping.ToTable("ReservationTable");
                        mapping.MapLeftKey("ReservationID");
                        mapping.MapRightKey("TableID");
                    });
            
            base.OnModelCreating(modelBuilder);
        }
        #endregion

    }
}
