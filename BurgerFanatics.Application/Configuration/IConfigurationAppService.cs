using System.Threading.Tasks;
using Abp.Application.Services;
using BurgerFanatics.Configuration.Dto;

namespace BurgerFanatics.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}