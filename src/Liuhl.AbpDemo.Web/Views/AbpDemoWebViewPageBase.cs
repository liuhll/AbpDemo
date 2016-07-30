using Abp.Web.Mvc.Views;

namespace Liuhl.AbpDemo.Web.Views
{
    public abstract class AbpDemoWebViewPageBase : AbpDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpDemoWebViewPageBase()
        {
            LocalizationSourceName = AbpDemoConsts.LocalizationSourceName;
        }
    }
}