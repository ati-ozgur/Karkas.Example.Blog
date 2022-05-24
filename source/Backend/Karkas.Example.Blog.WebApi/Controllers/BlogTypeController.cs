using Karkas.Example.Blog.BackendLibrary.Dal.LtCommon;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Karkas.Example.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogTypeController : ControllerBase
    {
        // GET: api/<BlogTypeController>
        [HttpGet]
        public List<BlogType> Get()
        {
            BlogTypeDal dal = new BlogTypeDal();
            var blogsTypes = dal.QueryAll();

            return blogsTypes;
        }

        // GET api/<BlogTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlogTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
