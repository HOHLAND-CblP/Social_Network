using Domain.Entities;

namespace Application.Models.UsersModels
{
    public class UserDetailsVm 
    {
        public ulong Id { get; set; }
        public string User_Name { get; set; }
        public string? First_Name { get; set; }
        public string Email { get; set; }
        public string Avatar_Url { get; set; }


        public static UserDetailsVm Mapping(User user)
        {
            return new UserDetailsVm
            {
                Id = user.Id,
                User_Name = user.User_Name,
                First_Name = user.First_Name,
                Email = user.Email
            };
        }
    }
}
