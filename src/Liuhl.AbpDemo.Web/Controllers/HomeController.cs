using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Liuhl.AbpDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}