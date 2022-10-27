using Lab1.Services.lab3;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Services.lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23, 23);
            return rectangle.GetArea();

        }

        [HttpGet]
        public int SumArea()
        {
            var rectangle = new Rectangle(3, 3);
            var rectangle2 = new Rectangle(4, 4);
            return rectangle + rectangle2;

        }
    }
}
