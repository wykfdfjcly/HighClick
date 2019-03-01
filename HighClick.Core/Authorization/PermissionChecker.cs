using Abp.Authorization;
using HighClick.Authorization.Roles;
using HighClick.Authorization.Users;

namespace HighClick.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
