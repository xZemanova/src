using System.Collections.Generic;
using BurgerFanatics.Roles.Dto;
using BurgerFanatics.Users.Dto;

namespace BurgerFanatics.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}