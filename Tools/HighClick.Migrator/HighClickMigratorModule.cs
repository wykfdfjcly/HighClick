using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using HighClick.EntityFramework;

namespace HighClick.Migrator
{
    [DependsOn(typeof(HighClickDataModule))]
    public class HighClickMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<HighClickDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}