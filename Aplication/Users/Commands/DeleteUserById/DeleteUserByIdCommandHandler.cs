using MediatR;
using Domain;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Commands.DeleteUser
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, string>
    {
        private IUsersDbContext _dbContext;

        public DeleteUserByIdCommandHandler(IUsersDbContext usersDbContext) =>
            _dbContext = usersDbContext;

        public async Task<string> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == request.Id, cancellationToken);

            if (user == null)
            {
                throw new KeyNotFoundException("User with id " + request.Id.ToString() + " not found");
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return $"User {user.Id} was deleted";
        }
    }
}
