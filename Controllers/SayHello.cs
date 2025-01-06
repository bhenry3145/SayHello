using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        public List<string> studentName = new();

        [HttpPost]
        [Route("AddName/{sayHelloTo}")]

        public List<string> AddName(string sayHelloTo)
        {
            studentName.Add("Hello, " + sayHelloTo);
            return studentName;
        }

    }
}