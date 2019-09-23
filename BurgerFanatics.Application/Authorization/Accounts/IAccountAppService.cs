using System.Threading.Tasks;
using Abp.Application.Services;
using BurgerFanatics.Authorization.Accounts.Dto;

namespace BurgerFanatics.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
