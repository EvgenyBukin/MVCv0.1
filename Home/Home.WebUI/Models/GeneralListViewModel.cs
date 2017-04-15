using Home.Domain.Entities;
using System.Collections.Generic;

namespace Home.WebUI.Models
{
    public class GeneralListViewModel
    {

        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<General> Generals { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}