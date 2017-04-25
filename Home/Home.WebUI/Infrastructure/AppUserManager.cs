using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Home.WebUI.Models;

namespace Home.WebUI.Infrastructure
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store)
            : base(store)
        { }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options,
            IOwinContext context)
        {
            AppIdentityDbContext db = context.Get<AppIdentityDbContext>();
            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(db));

            manager.PasswordValidator = new CustomPasswordValidator
            {
                RequiredLength = 6, //длина
                RequireNonLetterOrDigit = false, // наличие символов
                RequireDigit = false,
                RequireLowercase = true, // строчные символы
                RequireUppercase = true // прописные символы
            };

            manager.UserValidator = new CustomUserValidator();

            return manager;
        }
    }
}