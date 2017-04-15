using Home.Domain.Entities;
using System.Data.Entity;

namespace Home.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<General> Generals { get; set; }

        public DbSet<Article> Articles { get; set; }
    }
}
