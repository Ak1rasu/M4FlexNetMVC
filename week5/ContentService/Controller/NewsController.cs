using Mincrosoft.AspNetCore.Mvc;

namespace ContentService.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new string[] { "breaking news", "slow news" };
        }
    }
}