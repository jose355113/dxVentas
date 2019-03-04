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
    [Authorize(Roles = "Admin")]
    public class LgItemController : BaseController
    {
        private readonly ILgItemService lgItemServices;

        public LgItemController(ILgItemService pLgItemService)
        {
            lgItemServices = pLgItemService;
        }
        // GET: LgItem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = lgItemServices.GetAll(filtroPorNombre);
            return PartialView("IndexListadoLgItem", model);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(
        [ModelBinder(binderType:typeof(LgItemBinder))]
            LgItem model)
        {
            var result = lgItemServices.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = lgItemServices.GetById(id);
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(LgItem model)
        {
            var result = lgItemServices.Save(model);
            return RedirectToAction("Index");
        }


    }
}