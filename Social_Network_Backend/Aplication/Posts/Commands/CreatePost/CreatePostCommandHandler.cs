using MediatR;
using Application.Interfaces;
using Application.Models.PostsModels;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, PostDetailsVm>
    {
        private IPostsDbContext _dbContext;

/*        public CreatePostCommandHandler(IPostsDbContext dbContext) 
            => _dbContext = dbContext;*/

        public async Task<PostDetailsVm> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = new Post
            {
                Id = 0,
                User_Name = request.User_Name
            };

            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();

            return PostDetailsVm.Mapping(post);
        }
    }
}