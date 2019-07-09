using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services.Tests
{
    public class UserDummyRepo : IUserRepository
    {
        public IList<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int id)
        {
            return new User
            {
                Id = id,
                Email = "andrei@wtf.com"
            };
        }
    }
}
