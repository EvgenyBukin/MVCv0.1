using Home.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IGeneralRepository repository;

        public NavController(IGeneralRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Generals
                .Select(l => l.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}