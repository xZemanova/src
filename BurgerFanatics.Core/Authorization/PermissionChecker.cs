using Abp.Authorization;
using BurgerFanatics.Authorization.Roles;
using BurgerFanatics.Authorization.Users;

namespace BurgerFanatics.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
