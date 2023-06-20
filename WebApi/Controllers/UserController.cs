using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Queries.GerUserById;



namespace WebApi.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : BaseController
    {
        public UserController()
        {
            
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(ulong id)
        {
            var query = new GetUserByIdQuery
            {
                Id = id
            };

            var resp = await Mediator.Send(query);
            return Ok(resp);
        }

        [HttpPost]
        public async Task<ActionResult<ulong>> Create([FromBody] CreateUserCommand createUserCommand)
        {
            Console.WriteLine(createUserCommand);
            var resp = await Mediator.Send(createUserCommand);
            return Created("lolilopgames.com", resp);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(ulong id)
        {
            var request = new DeleteUserByIdCommand
            {
                Id = id
            };
            await Mediator.Send(request);
            return NoContent();
        }

        /*[HttpPut]
        public async Task<ActionResult> Update()
        {
            return Ok();
        }*/
    }
}
