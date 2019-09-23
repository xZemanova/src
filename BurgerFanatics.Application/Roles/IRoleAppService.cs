using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BurgerFanatics.Roles.Dto;

namespace BurgerFanatics.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
