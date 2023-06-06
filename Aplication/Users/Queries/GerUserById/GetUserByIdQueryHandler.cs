using Domain;
using MediatR;

namespace Application.Users.Queries.GerUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        public GetUserByIdQueryHandler() { }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Id = request.Id,
                User_Name = "hohland_cblp",
                First_Name = "Ismail",
                Last_Name = "Alzoabi",
                Email = "ismail987654321lkjhgfds@gmail.com",
                Creation_Date = new DateTime(2000, 7, 30)
            };

            return await Task.FromResult(user);
        }
    }
}
