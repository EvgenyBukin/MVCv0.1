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

        public void SaveArticle(Article article)
        {
            if(article.ArticleId == 0)
            {
                context.Articles.Add(article);
            } else {
                Article dbEntry = context.Articles.Find(article.ArticleId);
                if(dbEntry != null)
                {
                    dbEntry.Name = article.Name;
                    dbEntry.Description = article.Description;
                    dbEntry.ArticleTxt = article.ArticleTxt;
                    dbEntry.Img1 = article.Img1;
                    dbEntry.Img2 = article.Img2;
                    dbEntry.Data = article.Data;
                    dbEntry.Author = article.Author;
                    dbEntry.Img3 = article.Img3;
                }
            }
            context.SaveChanges();
        }

        public Article DeleteArticle(int articleId)
        {
            Article dbEntry = context.Articles.Find(articleId);
            if(dbEntry != null)
            {
                context.Articles.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
