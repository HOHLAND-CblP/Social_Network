using MediatR;
using Domain;

namespace Application.Users.Queries.GerUserById
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public ulong Id { get; set; }

    }
}
