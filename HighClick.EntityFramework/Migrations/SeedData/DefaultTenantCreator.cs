using System.Linq;
using HighClick.EntityFramework;
using HighClick.MultiTenancy;

namespace HighClick.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly HighClickDbContext _context;

        public DefaultTenantCreator(HighClickDbContext context)
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

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
