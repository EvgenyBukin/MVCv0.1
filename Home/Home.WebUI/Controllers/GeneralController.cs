using Home.Domain.Abstract;
using Home.WebUI.Models;
using Microsoft.Owin.Security;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.WebUI.Controllers
{
    public class GeneralController : Controller
    {

        private IGeneralRepository repository;
        private IArticleRepository repositoryA;
        private IArticleRepository repositoryB;

        public int pageSize = 4;
        public int pageSizeA = 8;

        public GeneralController(IGeneralRepository repo, IArticleRepository repoA)
        {
            repository = repo;

            repositoryA = repoA;

            repositoryB = repoA;

        }

        public ViewResult List(string category, int page = 1)
        {
            var lastEntry = repositoryA.Articles.Count();
            ViewBag.Articles = repositoryA.Articles.Skip(lastEntry - 1);
            ViewBag.ArticlesView = repositoryB.Articles
                .OrderByDescending(u => u.ArticleId)
                .Skip(lastEntry - (lastEntry - 1))
                .Take(pageSizeA);

            GeneralListViewModel model = new GeneralListViewModel
            {
                Generals = repository.Generals
                    .Where(p => category == null || p.Category == category)
                    .OrderByDescending(l => l.ModuleId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                repository.Generals.Count() :
                repository.Generals.Where(l => l.Category == category).Count()
                },
                CurrentCategory = category
            };

            return View(model);
        }

        public ActionResult ModulePage(int item_id)
        {
            var Item = repository.Generals.FirstOrDefault(x => x.ModuleId == item_id);
            return View(Item);               
        }

        public ActionResult ModulePageArticle(int itemA_id)
        {
            var ItemA = repositoryA.Articles.FirstOrDefault(x => x.ArticleId == itemA_id);
            return View(ItemA);
        }

        public ActionResult Inform()
        {
            return View();
        }

        public ActionResult ArchiveReviews(int page = 1)
        {
            GeneralListViewModel model = new GeneralListViewModel
            {
                Articles = repositoryA.Articles
                    .OrderByDescending(l => l.ArticleId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repositoryA.Articles.Count()
                }
            };
            return View(model);
        }

        public ActionResult Advertising()
        {
            return View();
        }

        public ActionResult Сontacts()
        {
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            AuthManager.SignOut();
            return null;
        }

        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}