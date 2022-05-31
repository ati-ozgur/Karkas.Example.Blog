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
        [HttpGet("{blogTypeNo}")]
        public BlogType Get(int blogTypeNo)
        {
            BlogTypeDal dal = new BlogTypeDal();
            BlogType bt = dal.QueryByBlogTypeNo(blogTypeNo);
            // TODO look about returning NotFound or giving an error
            return bt;
        }

        // POST api/<BlogTypeController>
        [HttpPost]
        public void Post([FromBody] BlogType bt)
        {
            BlogTypeDal blogTypeDal = new BlogTypeDal();
            blogTypeDal.Insert(bt);
        }

        // PUT api/<BlogTypeController>/5
        [HttpPut]
        public void Put([FromBody] BlogType bt)
        {
            BlogTypeDal blogTypeDal = new BlogTypeDal();
            blogTypeDal.Update(bt);

        }

        // DELETE api/<BlogTypeController>/5
        [HttpDelete("{blogTypeNo}")]
        public void Delete(int blogTypeNo)
        {
            BlogTypeDal blogTypeDal = new BlogTypeDal();
            blogTypeDal.Delete(blogTypeNo);
        }
    }
}
