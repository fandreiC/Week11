namespace UserPosts.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}
