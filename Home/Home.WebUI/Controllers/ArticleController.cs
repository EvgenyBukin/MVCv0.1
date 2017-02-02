using Home.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleRepository repository;

        public ArticleController(IArticleRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Articles);
        }
    }
}