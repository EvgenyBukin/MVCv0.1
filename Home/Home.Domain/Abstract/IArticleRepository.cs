using Home.Domain.Entities;
using System.Collections.Generic;


namespace Home.Domain.Abstract
{
    public interface IArticleRepository
    {
        IEnumerable<Article> Articles { get; }
        void SaveArticle(Article article);
        Article DeleteArticle(int articleId);
    }
}
