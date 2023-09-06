using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PostController : BaseController
    {
        public PostController() { }

        [HttpPost]
        public async Task<ActionResult<ulong>> CreatePost()
        {
            return Created("lolilopgames.com", 111);
        }
    }
}
