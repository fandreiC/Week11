using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPosts.Domain
{
    public class Comment:BaseEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; }
    }
}
