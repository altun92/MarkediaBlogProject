using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkediaBlogProject.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        public int ArticleId { get; set; }
        public Article Articles { get; set; }
    }
}
