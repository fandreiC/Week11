using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services.Tests
{
    public class PostDummyRepo : IPostRepository
    {
        public IList<Post> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Post> GetPostsByUserId(int id)
        {
            var list = new List<Post>();

            list.Add(new Post());
            list.Add(new Post());
            list.Add(new Post());
            list.Add(new Post());

            return list;
        }
    }
}
