using MediatR;

namespace Application.Users.Commands.DeleteUser
{
    public class DeleteUserByIdCommand : IRequest<string>
    {
        public long Id { get; set; }
    }
}