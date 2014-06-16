﻿using Abp.Web.Mvc.Views;

namespace MySpaProject.WebSpaDurandal.Views
{
    public abstract class MySpaProjectWebViewPageBase : MySpaProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class MySpaProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MySpaProjectWebViewPageBase()
        {
            LocalizationSourceName = "MySpaProject";
        }
    }
}