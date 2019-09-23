using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BurgerFanatics.EntityFramework;

namespace BurgerFanatics
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BurgerFanaticsCoreModule))]
    public class BurgerFanaticsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BurgerFanaticsDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
