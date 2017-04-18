using Home.Domain.Abstract;
using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Home.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IGeneralRepository repository;

        IArticleRepository repositoryA;

        public AdminController (IGeneralRepository repo, IArticleRepository repoA)
        {
            repository = repo;

            repositoryA = repoA;
        }

        /***************************New****************************/
        public ViewResult IndexA()
        {
            return View(repositoryA.Articles);
        }

        public ViewResult EditA(int articleId)
        {
            Article article = repositoryA.Articles
                .FirstOrDefault(b => b.ArticleId == articleId);
            return View(article);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditA(Article article)
        {
            if (ModelState.IsValid)
            {
                repositoryA.SaveArticle(article);
                TempData["message"] = string.Format("Измменения \"{0}\" были сохранены", article.Name);
                return RedirectToAction("IndexA");
            } else {
                return View(article);
            }
        }

        public ViewResult CreateA()
        {
            return View("EditA", new Article());
        }

        [HttpPost]
        public ActionResult DeleteA(int articleId)
        {
            Article deletedArticle = repositoryA.DeleteArticle(articleId);
            if(deletedArticle != null)
            {
                TempData["message"] = string.Format("Запись \"{0}\" была удалена",
                    deletedArticle.Name);
            }
            return RedirectToAction("IndexA");
        }

        /**********************************************************/

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