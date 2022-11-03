using Lab1.Services.lab4;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers.lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.getLang();
        }
    }
}
