using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface ICommentRepository: IBaseRepository<Comment>
    {
        IList<Comment> GetCommentsForPostId(int id);
        

    }
}
