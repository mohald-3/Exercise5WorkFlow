using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        // GET /api/math/add?x=2&y=3
        [HttpGet("add")]
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}