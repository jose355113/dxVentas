using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Entities.Base;
using System.Web.Mvc;

namespace App.UI.Web.MVC.ModelBinders
{
    public class LgFamIteBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            LgFamIte model = new LgFamIte();
            model.des_famitem = HttpContext.Current.Request.Form["des_famitem"];

            return model;
        }
    }
}