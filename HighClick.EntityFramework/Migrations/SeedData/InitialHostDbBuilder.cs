using HighClick.EntityFramework;
using EntityFramework.DynamicFilters;

namespace HighClick.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly HighClickDbContext _context;

        public InitialHostDbBuilder(HighClickDbContext context)
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
