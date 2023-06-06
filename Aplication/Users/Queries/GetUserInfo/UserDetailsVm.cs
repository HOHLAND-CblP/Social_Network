using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserInfo
{
    public class UserDetailsVm
    {
        public ulong Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        

        public UserDetailsVm(User user)
        {
            Id = user.Id;
            UserName = user.User_Name;
            FirstName = user.First_Name;
            LastName = user.Last_Name;
            Email = user.Email;
            CreationDate = user.Creation_Date;
        }
    }
}