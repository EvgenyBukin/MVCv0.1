using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Web.Mvc;

namespace Home.WebUI.Infrastructure
{
    public static class IdentityHelpers
    {
        public static MvcHtmlString GetUserName(this HtmlHelper html, string id)
        {
            AppUserManager mrg = HttpContext.Current
                .GetOwinContext().GetUserManager<AppUserManager>();

            return new MvcHtmlString(mrg.FindByIdAsync(id).Result.UserName);
        }
    }
}