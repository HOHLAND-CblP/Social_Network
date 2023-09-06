using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserInfo
{
    public class GetUserInfoQueryHandler
    {
        public async Task<UserDetailsVm> Handle(GetUserInfoQuery request)
        {
            User user = new User
            {
                Id = 0,
                User_Name = "HOHLAND_CblP",
                First_Name = "Ismail",
                Last_Name = "Alzoabi",
                Email = "ismail987654321lkjhgfdsa@gmail.com",
                Creation_Date = DateTime.Now
            };

            UserDetailsVm vm = new UserDetailsVm(user);

            if (vm == null ||  vm.Id !=request.Id)
            {
                throw new DirectoryNotFoundException();
            }

            return vm;
        }
    }
}
