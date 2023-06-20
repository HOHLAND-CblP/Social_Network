using MediatR;

namespace Application.Users.Commands.DeleteUser
{
    public class DeleteUserByIdCommand : IRequest<string>
    {
        public ulong Id { get; set; }
    }
}