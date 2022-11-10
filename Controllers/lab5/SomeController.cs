using Lab1.Services.lab5;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers.lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
