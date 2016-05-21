using Abp.Web.Mvc.Views;

namespace Esp.Auth.Web.Views
{
    public abstract class AuthWebViewPageBase : AuthWebViewPageBase<dynamic>
    {

    }

    public abstract class AuthWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AuthWebViewPageBase()
        {
            LocalizationSourceName = AuthConsts.LocalizationSourceName;
        }
    }
}