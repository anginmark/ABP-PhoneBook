using System.Threading.Tasks;
using LZRY.PACS.Configuration.Dto;

namespace LZRY.PACS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
