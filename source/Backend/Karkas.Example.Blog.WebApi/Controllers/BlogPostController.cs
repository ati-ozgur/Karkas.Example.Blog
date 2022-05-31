using Karkas.Example.Blog.BackendLibrary.Bs.ContentManagent;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.ContentManagent;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Karkas.Example.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        // GET: api/<BlogPostController>
        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {


            BlogPostBs blogPostBs = new BlogPostBs();
            var posts = blogPostBs.QueryAll();

            return posts;
        }

        // GET api/<BlogPostController>/5
        [HttpGet("{blogPostKey}")]
        public BlogPost Get(Guid blogPostKey)
        {
            BlogPostBs blogPostBs = new BlogPostBs();
            BlogPost bp = blogPostBs.QueryByBlogPostKey(blogPostKey);
            return bp;
        }

        // POST api/<BlogPostController>
        [HttpPost]
        public void Post([FromBody] BlogPost bp)
        {
            BlogPostBs blogPostBs = new BlogPostBs();
            blogPostBs.Insert(bp);

        }

        // PUT api/<BlogPostController>/5
        [HttpPut]
        public void Put([FromBody] BlogPost bp)
        {
            BlogPostBs blogPostBs = new BlogPostBs();
            blogPostBs.Update(bp);
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{blogPostKey}")]
        public void Delete(Guid blogPostKey)
        {
            BlogPostBs blogPostBs = new BlogPostBs();
            blogPostBs.Delete(blogPostKey);
        }
    }
}
