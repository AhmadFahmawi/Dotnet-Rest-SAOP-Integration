using Microsoft.AspNetCore.Mvc;

namespace RestApp.Controllers
{
    [ApiController]
    [Route("RestApp/[controller]")]
    public class CallableController :ControllerBase
    {
        [HttpGet(Name = "HealthCheck")]
        public bool HealthCheck()
        {
            return true;
        }
    }
}
