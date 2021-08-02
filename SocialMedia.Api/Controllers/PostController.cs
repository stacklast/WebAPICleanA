using Microsoft.AspNetCore.Mvc;

using SocialMedia.Infraestructure.Repositories;

namespace SocialMedia.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
        }
    }
}