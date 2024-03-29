﻿using MediatR;
using Application.Interfaces;
using Application.Models.UsersModels;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDetailsVm>
    {
        private IApplicationDbContext _dbContext;

        public CreateUserCommandHandler(IApplicationDbContext dbContext)
            => _dbContext = dbContext;

        public async Task<UserDetailsVm> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                //Id = 1,
                User_Name = request.User_Name,
                First_Name = request.First_Name,
                Last_Name = request.Last_Name,
                Email = request.Email,
                Creation_Date = DateTime.UtcNow
            };

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            /*user = await _dbContext.Users.FirstOrDefaultAsync(user_ => user_.Id == user.Id, cancellationToken); */

            return UserDetailsVm.Mapping(user);
        }
    }
}