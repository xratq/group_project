using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Crazy
{

    class ShopContext : DbContext
    {
        public DbSet<Educational_building> Educational_buildings { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<Additional_characteristic> Additional_characteristics { get; set; }
        public DbSet<Software_list> Software_lists { get; set; }
        public DbSet<Equipment_list> Equipment_lists { get; set; }

        public ShopContext() : base(nameOrConnectionString: "PGConnectionString") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}