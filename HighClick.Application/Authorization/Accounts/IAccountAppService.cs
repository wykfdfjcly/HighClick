using System.Threading.Tasks;
using Abp.Application.Services;
using HighClick.Authorization.Accounts.Dto;

namespace HighClick.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
