﻿using System.Collections.Generic;
using BurgerFanatics.Roles.Dto;

namespace BurgerFanatics.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}