using System.Threading.Tasks;
using Abp.Application.Services;
using BurgerFanatics.Sessions.Dto;

namespace BurgerFanatics.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
