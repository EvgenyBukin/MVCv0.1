using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Domain.Entities
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ArticleTxt { get; set; }

        public string Img1 { get; set; }

        public string Img2 { get; set; }

        public string Data { get; set; }

        public string Author { get; set; }

        public string Img3 { get; set; }
    }
}
