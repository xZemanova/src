using Abp.Web.Mvc.Views;

namespace BurgerFanatics.Web.Views
{
    public abstract class BurgerFanaticsWebViewPageBase : BurgerFanaticsWebViewPageBase<dynamic>
    {

    }

    public abstract class BurgerFanaticsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BurgerFanaticsWebViewPageBase()
        {
            LocalizationSourceName = BurgerFanaticsConsts.LocalizationSourceName;
        }
    }
}