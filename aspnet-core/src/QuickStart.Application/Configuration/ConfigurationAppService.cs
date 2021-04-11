using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QuickStart.Configuration.Dto;

namespace QuickStart.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QuickStartAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
