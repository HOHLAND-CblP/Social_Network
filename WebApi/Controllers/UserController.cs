using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GerUserById;


namespace WebApi.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public UserController (IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(ulong id)
        {
            var query = new GetUserByIdQuery
            {
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<ulong>> Create([FromQuery]CreateUserCommand createUserCommand)
        {
            Console.WriteLine(createUserCommand);
            var i = await Mediator.Send(createUserCommand);
            return Created("lolilopgames.com", i) ;
        }

        /*[HttpPut]
        public async Task<ActionResult> Update()
        {
            return Ok();
        }*/
    }
}
