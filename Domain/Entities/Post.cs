﻿namespace Domain.Entities
{
    public class Post : BaseEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
    }
}
