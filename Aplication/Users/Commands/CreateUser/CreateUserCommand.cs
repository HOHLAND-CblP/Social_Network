using Application.Models.UsersModels;
using MediatR;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<UserDetailsVm>
    {
        public string User_Name { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}