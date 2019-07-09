using System.Collections.Generic;
using UserPosts.Domain;
using System.Collections.Generic;
using System.Linq;

namespace UserPosts.Services
{
    public enum UserPostsStatus
    {
        Inactive,
        Active,
        Superactive
    }

    public class UserService
    {
        private readonly IUserRepository userRepository;
        private readonly IPostRepository postRepository;
        private readonly ICommentRepository commentRepository;

        public UserService(IUserRepository userRepository, IPostRepository postRepository)
        {
            this.userRepository = userRepository;
            this.postRepository = postRepository;
        }
        public UserService(IUserRepository userRepository, IPostRepository postRepository, ICommentRepository commentRepository)
        {
            this.userRepository = userRepository;
            this.postRepository = postRepository;
            this.commentRepository = commentRepository;
        }

        public UserActiveRespose GetUserActiveRespose(int id)
        {
            var response = new UserActiveRespose();

            var user = this.userRepository.GetById(id);

            response.Email = user.Email;

            var posts = this.postRepository.GetPostsByUserId(id);

            var numberOfPosts = posts.Count;

            if(numberOfPosts < 5)
            {
                response.Status = UserPostsStatus.Inactive;
            }
            else
            {
                if (numberOfPosts > 5 && numberOfPosts < 10)
                {
                    response.Status = UserPostsStatus.Active;
                }
                else
                {
                    if (numberOfPosts >= 10)
                    {
                        response.Status = UserPostsStatus.Superactive;
                    }
                }
            }
           
            return response;
        }
        public CommentsForUser GetCommentsForUserId(int id)
        {
            var response = new CommentsForUser();
            var user = userRepository.GetById(id);
            response.name = user.Name;
            var posts = this.postRepository.GetPostsByUserId(id);
            //var comments = posts.Where(x => x.UserId==id).ToList();
            //var comList = commentRepository.GetCommentsForPostId(2);
            foreach (var post in posts)
            {

                //response.comments.Add(x => x.PostId == 3);
                var lista = commentRepository.GetCommentsForPostId(post.Id);
                //response.comments.Add(commentRepository.GetCommentsForPostId(post.Id));
                foreach (var item in lista)
                {
                    response.comments.Add(item);
                }                
            }
            return response;
        }
        public class CommentsForUser
        {
            public string name { get; set; }
            public IList<Comment> comments { get; set; }
        }

    }

    
}
