using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [Route("{id:int:min(5)}")]
        public string Get1(int id)
        {
            return "Hello from integer";
        }
        [HttpGet]
        [Route("{id:regex(^book)}/{i:regex(^(zoom|boom))}")]
        public string Get2(string id,string i)
        {
            return "Hello from regex";
        }
        [HttpGet]
        [Route("{id:alpha}")]
        public string Get3(string id)
        {
            return "Hello from alpha";
        }
    }
}
