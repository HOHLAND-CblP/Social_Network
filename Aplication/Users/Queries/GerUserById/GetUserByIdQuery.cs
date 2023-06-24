using MediatR;
using Domain.Entities;

namespace Application.Users.Queries.GerUserById
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public ulong Id { get; set; }

    }
}
