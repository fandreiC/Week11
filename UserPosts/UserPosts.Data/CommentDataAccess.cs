using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    class CommentDataAccess : BaseDataAccess<Comment>, ICommentRepository
    {
        protected override string GetFile()
        {
            return @"D:\projects\wantsome\week11\UserPosts\UserPosts.Data\Files\comments.json";
        }
        public IList<Comment> GetCommentsForPostId(int id)
        {
            var list = this.GetAll();
            return list.Where(x => x.PostId == id).ToList();
        }
    }
}
