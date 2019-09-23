using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BurgerFanatics.Roles.Dto;
using BurgerFanatics.Users.Dto;

namespace BurgerFanatics.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}