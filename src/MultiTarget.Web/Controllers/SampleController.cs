using Microsoft.AspNetCore.Mvc;
#if NET7_0
// use alias to make old look like new for other code
using SampleService = MultiTarget.Web.Services.SampleServiceOld;
#else
using MultiTarget.Web.Services;
#endif

namespace MultiTarget.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet(Name = "DoSomething")]
        public IActionResult DoSomething()
        {
            var service = HttpContext.RequestServices.GetRequiredService<SampleService>();

            return Ok(service.DoSomething());
        }
    }
}
