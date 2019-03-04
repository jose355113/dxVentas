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
    public class LgProveedorController : Controller
    {

        private readonly ILgProveedorService lgProveedorServices;

        public LgProveedorController(ILgProveedorService pLgProveedorService)
        {
            lgProveedorServices = pLgProveedorService;
        }
        // GET: LgItem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string filtroPorNombre)
        {
            filtroPorNombre = filtroPorNombre != null ? filtroPorNombre : "";
            var model = lgProveedorServices.GetAll(filtroPorNombre);
            return PartialView("IndexListadoLgProveedor", model);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(
        [ModelBinder(binderType:typeof(LgProveedorBinder))]
            LgProveedor model)
        {
            var result = lgProveedorServices.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = lgProveedorServices.GetById(id);
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(LgProveedor model)
        {
            var result = lgProveedorServices.Save(model);
            return RedirectToAction("Index");
        }

    }
}