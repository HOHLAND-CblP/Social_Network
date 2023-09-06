using MediatR;
using Domain.Entities;

namespace Application.Users.Queries.GerUserById
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public long Id { get; set; }

    }
}
