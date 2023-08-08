using Application.Models.PostsModels;
using MediatR;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<PostDetailsVm>
    { 
        public string User_Name{ get; set;}
    }
}
