using System.Web.Mvc;

namespace Liuhl.AbpDemo.Web.Controllers
{
    public class AboutController : AbpDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}