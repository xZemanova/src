using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BurgerFanatics.MultiTenancy.Dto;

namespace BurgerFanatics.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
