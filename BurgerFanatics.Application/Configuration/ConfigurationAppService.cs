using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BurgerFanatics.Configuration.Dto;

namespace BurgerFanatics.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BurgerFanaticsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
