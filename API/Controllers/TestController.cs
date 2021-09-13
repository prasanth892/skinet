using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<test> Get()
        {
            var mytest = new test { Id = 1, Name = "Jack" };
            List<test> mytestList = new List<test>();

            mytestList.Add(mytest);

            return mytestList;
        }

    }
}