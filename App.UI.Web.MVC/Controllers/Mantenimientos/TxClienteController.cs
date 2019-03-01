using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Domain.Services;
using App.Domain.Services.Interfaces;
using App.Entities.Base;
using App.UI.Web.MVC.ModelBinders;

namespace App.UI.Web.MVC.Controllers.Mantenimientos
{
    [Authorize(Roles = "Admin")]
    public class TxClienteController : BaseController
    {

        private readonly ITxClienteService txClienteServices;

        public TxClienteController(ITxClienteService pCategoriaServices)
        {
            txClienteServices = pCategoriaServices;
        }
        // GET: TxCliente
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = txClienteServices.GetAll(filtroPorNombre);
            return PartialView("IndexListado", model);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(
    [ModelBinder(binderType:typeof(TxClienteBinder))]
            TxCliente model)
        {
            var result = txClienteServices.Save(model);
            return RedirectToAction("Index");
        }


    }
}