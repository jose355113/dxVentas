using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Entities.Base;
using System.Web.Mvc;

namespace App.UI.Web.MVC.ModelBinders
{
    public class LgProveedorBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            LgProveedor model = new LgProveedor();
            model.Des_Proveedor = HttpContext.Current.Request.Form["Des_Proveedor"];
            model.Num_Ruc = HttpContext.Current.Request.Form["Ruc"];

            return model;
        }
    }
}