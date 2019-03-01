using System.Threading.Tasks;
using Abp.Application.Services;
using HighClick.Configuration.Dto;

namespace HighClick.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}