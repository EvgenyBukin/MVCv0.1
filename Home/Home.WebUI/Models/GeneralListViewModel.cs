using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.WebUI.Models
{
    public class GeneralListViewModel
    {
        public IEnumerable<General> Generals { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}