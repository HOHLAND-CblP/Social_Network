namespace Domain.Entities
{
    public class Post : BaseEntity
    {
        public ulong Id { get; set; }
        public ulong User_Id { get; set; }
        public string Text { get; set; }
    }
}
