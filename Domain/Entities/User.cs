﻿namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public long Id { get; set; }
        public string User_Name { get; set; }
        public string? Email { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        //public Media? Avatar { get; set; }
    }
}