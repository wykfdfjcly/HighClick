using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HighClick.Roles.Dto;
using HighClick.Users.Dto;

namespace HighClick.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}