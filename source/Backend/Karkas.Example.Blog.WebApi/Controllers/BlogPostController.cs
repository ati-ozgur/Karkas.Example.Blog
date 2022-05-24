using Karkas.Example.Blog.BackendLibrary.Dal.ContentManagent;
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
            BlogPostDal blogPostDal = new BlogPostDal();
            var posts = blogPostDal.QueryAll();

            return posts;
        }

        // GET api/<BlogPostController>/5
        [HttpGet("{blogPostKey}")]
        public BlogPost Get(Guid blogPostKey)
        {
            BlogPostDal blogPostDal = new BlogPostDal();
            BlogPost bp = blogPostDal.SorgulaBlogPostKeyIle(blogPostKey);
            return bp;
        }

        // POST api/<BlogPostController>
        [HttpPost]
        public void Post([FromBody] BlogPost bp)
        {
            BlogPostDal blogPostDal = new BlogPostDal();
            blogPostDal.Insert(bp);

        }

        // PUT api/<BlogPostController>/5
        [HttpPut]
        public void Put([FromBody] BlogPost bp)
        {
            BlogPostDal blogPostDal = new BlogPostDal();
            blogPostDal.Update(bp);
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{blogPostKey}")]
        public void Delete(Guid blogPostKey)
        {
            BlogPostDal blogPostDal = new BlogPostDal();
            blogPostDal.Delete(blogPostKey);
        }
    }
}
