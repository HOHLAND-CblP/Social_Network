using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Queries.GerUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private IUsersDbContext _dbContext;

        public GetUserByIdQueryHandler(IUsersDbContext dbContext)
            => _dbContext = dbContext;


        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == request.Id, cancellationToken);

            if (user == null) 
            {
                throw new KeyNotFoundException("User with id " + request.Id.ToString() + " not found");
            }

            return user;
        }
    }
}
