using Domain.Entities;

namespace Application.Models.PostsModels
{
    public class PostDetailsVm
    {
        public ulong Id { get; set; }
        public ulong User_Id { get; set; }

        public static PostDetailsVm Mapping(Post post)
        {
            return new PostDetailsVm
            {
                Id = post.Id,
                User_Id = post.User_Id,/*
                First_Name = user.First_Name,
                Email = user.Email*/
            };
        }
    }
}
