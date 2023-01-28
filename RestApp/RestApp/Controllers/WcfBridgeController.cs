using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;


namespace RestApp.Controllers
{
    [ApiController]
    [Route("WcfBridge/[controller]")]
    public class WcfBridgeController  :ControllerBase
    {

        [HttpGet]
        [Route("WcfHealthCheck")]
        public Task<bool> WcfHealthCheck()
        {
            return new WcfHealthCheckServiceClient().HealthCheckAsync();
        }
        [HttpGet]
        [Route("SayHello")]
        public Task<string> SayHello(string name)
        {
            CompositeType composite = new CompositeType();
            composite.Name= name;
            return new WcfHealthCheckServiceClient().SayHelloAsync(composite);
        }
    }
}
