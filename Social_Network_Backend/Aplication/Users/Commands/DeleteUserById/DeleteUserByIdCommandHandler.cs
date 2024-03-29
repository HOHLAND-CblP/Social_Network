﻿using MediatR;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Users.Commands.DeleteUser
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, string>
    {
        private IApplicationDbContext _dbContext;

        public DeleteUserByIdCommandHandler(IApplicationDbContext usersDbContext) =>
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
