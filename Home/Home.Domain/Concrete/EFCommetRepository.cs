using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Domain.Concrete
{
    public class EFCommetRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Comment> Comments
        {
            get { return context.Comments; }
        }
    }
}
