using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Domain.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public int RecordId { get; set; }
        public int UserId { get; set; }
    }
}
