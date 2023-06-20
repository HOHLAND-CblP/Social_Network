namespace Domain
{
    public class User
    {
        public ulong Id { get; set; }
        public string User_Name { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Creation_Date { get; set; }
        public string Avatar_Url { get; set; }
    }
}