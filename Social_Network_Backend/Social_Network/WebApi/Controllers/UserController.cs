using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController
    {
        public async Task<ActionResult<long>> Create()
        {
            long lo = 1234;
            return Ok(lo);
        }
    }
}
