using Abp.Web.Mvc.Views;

namespace HighClick.Web.Views
{
    public abstract class HighClickWebViewPageBase : HighClickWebViewPageBase<dynamic>
    {

    }

    public abstract class HighClickWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected HighClickWebViewPageBase()
        {
            LocalizationSourceName = HighClickConsts.LocalizationSourceName;
        }
    }
}