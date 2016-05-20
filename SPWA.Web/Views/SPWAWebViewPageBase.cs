using Abp.Web.Mvc.Views;

namespace SPWA.Web.Views
{
    public abstract class SPWAWebViewPageBase : SPWAWebViewPageBase<dynamic>
    {

    }

    public abstract class SPWAWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SPWAWebViewPageBase()
        {
            LocalizationSourceName = SPWAConsts.LocalizationSourceName;
        }
    }
}