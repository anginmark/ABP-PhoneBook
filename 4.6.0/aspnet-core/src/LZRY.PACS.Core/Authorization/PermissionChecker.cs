using Abp.Authorization;
using LZRY.PACS.Authorization.Roles;
using LZRY.PACS.Authorization.Users;

namespace LZRY.PACS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
