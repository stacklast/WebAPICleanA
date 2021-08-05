using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using SocialMedia.Core.Interfaces;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;

namespace SocialMedia.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostController(IPostRepository postRepository, IMapper mapper )
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts() 
        {
            var posts = await _postRepository.GetPosts();
            var postDto =  _mapper.Map<IEnumerable<PostDto>>( posts );
            return Ok(posts);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id) 
        {
            var post = await _postRepository.GetPost(id);
            
            var postDto = _mapper.Map<PostDto>( post);
            return Ok(postDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDto postDto) 
        {
            var post = _mapper.Map<Publicacion>( postDto);
            await _postRepository.InsertPost(post);
            return Ok(post);
        }
    }
}