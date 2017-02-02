using Home.Domain.Abstract;
using Home.Domain.Entities;
using Home.WebUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace Home.WebUI.Controllers
{
    public class GeneralController : Controller
    {
        private IGeneralRepository repository;
        public int pageSize = 4;

        public GeneralController(IGeneralRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int page = 1)
        {
            GeneralListViewModel model = new GeneralListViewModel
            {
                Generals = repository.Generals
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(l => l.ModuleId)
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

        /*public FileContentResult GetImage(int moduleId)
        {
            General general = repository.Generals
                .FirstOrDefault(g => g.ModuleId == moduleId);
            if(general != null)
            {
                return File(general.ImageData, general.ImageMimeType);
            }
            else
            {
                return null;
            }
        }*/
    }
}