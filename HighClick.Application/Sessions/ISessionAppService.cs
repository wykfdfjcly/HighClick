using System.Threading.Tasks;
using Abp.Application.Services;
using HighClick.Sessions.Dto;

namespace HighClick.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
