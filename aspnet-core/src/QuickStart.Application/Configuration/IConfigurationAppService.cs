using System.Threading.Tasks;
using QuickStart.Configuration.Dto;

namespace QuickStart.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
