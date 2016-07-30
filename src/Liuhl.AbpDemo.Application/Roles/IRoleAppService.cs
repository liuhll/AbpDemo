using System.Threading.Tasks;
using Abp.Application.Services;
using Liuhl.AbpDemo.Roles.Dto;

namespace Liuhl.AbpDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
