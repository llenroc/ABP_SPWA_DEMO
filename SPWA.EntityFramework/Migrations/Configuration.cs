using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using SPWA.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using SPWA.People;

namespace SPWA.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SPWA.EntityFramework.SPWADbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SPWA";
        }

        protected override void Seed(SPWA.EntityFramework.SPWADbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }
            context.Person.AddOrUpdate(p => p.Name,
            new Person { Name = "Joye.NET", Age = 25 },
            new Person { Name = "Jerry.Core", Age = 25 },
            new Person { Name = "longhao", Age = 25 },
            new Person { Name = "xmm", Age = 25 });
            context.SaveChanges();
        }
    }
}
