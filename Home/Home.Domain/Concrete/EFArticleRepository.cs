using Home.Domain.Abstract;
using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Domain.Concrete
{
    public class EFArticleRepository : IArticleRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Article> Articles
        {
            get { return context.Articles; }
        }
    }
}
