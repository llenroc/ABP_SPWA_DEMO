using SPWA.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SPWA.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SPWADbContext _context;

        public InitialHostDbBuilder(SPWADbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
