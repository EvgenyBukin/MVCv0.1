using Home.Domain.Abstract;
using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IGeneralRepository repository;

        public AdminController (IGeneralRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Generals);
        }

        public ViewResult Edit(int moduleId)
        {
            General general = repository.Generals
                .FirstOrDefault(g => g.ModuleId == moduleId);
            return View(general);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(General general)
        {
            if (ModelState.IsValid)
            {
                repository.Save(general);
                TempData["message"] = string.Format("Измменения \"{0}\" были сохранены", general.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(general);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new General());
        }

        [HttpPost]
        public ActionResult Delete(int moduleId)
        {
            General deleted = repository.Delete(moduleId);
            if(deleted != null)
            {
                TempData["message"] = string.Format("Запись \"{0}\" была удалена",
                    deleted.Name);
            }
            return RedirectToAction("Index");
        }
    }
}