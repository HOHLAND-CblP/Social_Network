using MediatR;
using Domain;
using Application.Interfaces;
using Application.Models.UsersModels;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDetailsVm>
    {
        private IUsersDbContext _dbContext;

        public CreateUserCommandHandler(IUsersDbContext dbContext)
            => _dbContext = dbContext;

        public async Task<UserDetailsVm> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                User_Name = request.User_Name,
                First_Name = request.First_Name,
                Last_Name = request.Last_Name,
                Email = request.Email,
                Password = request.Password,
                Creation_Date = DateTime.UtcNow
            };

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            //user = await _dbContext.Users.FirstOrDefaultAsync(user_ => user_.Id == user.Id, cancellationToken); 

            return UserDetailsVm.Mapping(user);
        }
    }
}