using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        IList<Post> GetPostsByUserId(int id);
    }
}