using Microsoft.AspNetCore.Mvc;

using SocialMedia.Core.Interfaces;
using SocialMedia.Core.Entities;
using SocialMedia.Infraestructure.Repositories;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository )
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts() 
        {
            var posts = await _postRepository.GetPosts();
            return Ok(posts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id) 
        {
            var post = await _postRepository.GetPost(id);
            return Ok(post);
        }
    }
}