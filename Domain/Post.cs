namespace Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime Creation { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
