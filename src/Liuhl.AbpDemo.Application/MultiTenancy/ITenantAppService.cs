using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Liuhl.AbpDemo.MultiTenancy.Dto;

namespace Liuhl.AbpDemo.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
