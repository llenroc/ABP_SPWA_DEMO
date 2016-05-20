using System.Linq;
using SPWA.EntityFramework;
using SPWA.MultiTenancy;

namespace SPWA.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SPWADbContext _context;

        public DefaultTenantCreator(SPWADbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == "Default");
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = "Default", Name = "Default"});
                _context.SaveChanges();
            }
        }
    }
}