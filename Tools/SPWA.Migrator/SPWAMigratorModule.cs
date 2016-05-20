using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SPWA.EntityFramework;

namespace SPWA.Migrator
{
    [DependsOn(typeof(SPWADataModule))]
    public class SPWAMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SPWADbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}