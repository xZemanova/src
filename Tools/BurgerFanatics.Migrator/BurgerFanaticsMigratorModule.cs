using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BurgerFanatics.EntityFramework;

namespace BurgerFanatics.Migrator
{
    [DependsOn(typeof(BurgerFanaticsDataModule))]
    public class BurgerFanaticsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BurgerFanaticsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}