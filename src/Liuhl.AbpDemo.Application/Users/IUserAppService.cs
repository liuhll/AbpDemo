using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Liuhl.AbpDemo.Users.Dto;

namespace Liuhl.AbpDemo.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultOutput<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}