using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using BurgerFanatics.Authorization.Roles;
using BurgerFanatics.Authorization.Users;
using BurgerFanatics.Models;
using BurgerFanatics.MultiTenancy;

namespace BurgerFanatics.EntityFramework
{
    public class BurgerFanaticsDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Location> Locations { get; set; }
        
        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public BurgerFanaticsDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BurgerFanaticsDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BurgerFanaticsDbContext since ABP automatically handles it.
         */
        public BurgerFanaticsDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BurgerFanaticsDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public BurgerFanaticsDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
