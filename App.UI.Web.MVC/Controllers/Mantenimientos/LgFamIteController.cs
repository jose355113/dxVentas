using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Domain.Services.Interfaces;
using App.Entities.Base;
using App.UI.Web.MVC.ModelBinders;


namespace App.UI.Web.MVC.Controllers.Mantenimientos
{
    public class LgFamIteController : Controller
    {

        private readonly ILgFamIteService lgFamIteServices;

        public LgFamIteController(ILgFamIteService pLgFamIteServices)
        {
            lgFamIteServices = pLgFamIteServices;
        }
        // GET: TxCliente
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = lgFamIteServices.GetAll(filtroPorNombre);
            return PartialView("IndexListadoLgFamItem", model);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(
          [ModelBinder(binderType:typeof(LgFamIteBinder))]
            LgFamIte model)
        {
            var result = lgFamIteServices.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = lgFamIteServices.GetById(id);
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(LgFamIte model)
        {
            var result = lgFamIteServices.Save(model);
            return RedirectToAction("Index");
        }

    }
}