using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HighClick.MultiTenancy.Dto;

namespace HighClick.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
