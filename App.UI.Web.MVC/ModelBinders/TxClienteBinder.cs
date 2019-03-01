using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Entities.Base;
using System.Web.Mvc;

namespace App.UI.Web.MVC.ModelBinders
{
    public class TxClienteBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            TxCliente model = new TxCliente();
            model.Nom_Cliente = HttpContext.Current.Request.Form["Nombre"];
            model.Num_Ruc = HttpContext.Current.Request.Form["Ruc"];

            return model;
        }
    }
}