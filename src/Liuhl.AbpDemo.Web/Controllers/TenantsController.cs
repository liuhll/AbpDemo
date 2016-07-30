using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Liuhl.AbpDemo.Authorization;
using Liuhl.AbpDemo.MultiTenancy;

namespace Liuhl.AbpDemo.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AbpDemoControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}