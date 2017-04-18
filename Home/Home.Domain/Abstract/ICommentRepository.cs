using Home.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Domain.Abstract
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> Comments { get; }
    }
}
