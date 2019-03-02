using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Entities.Base;
using System.Web.Mvc;

namespace App.UI.Web.MVC.ModelBinders
{
    public class LgItemBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            LgItem model = new LgItem();
            model.Des_Item  = HttpContext.Current.Request.Form["Des_Item"];
            model.Cod_FamItem  = HttpContext.Current.Request.Form["cod_FamItem"];
            return model;
        }
    }
}