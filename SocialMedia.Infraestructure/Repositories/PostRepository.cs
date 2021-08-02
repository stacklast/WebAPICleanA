using System.Collections.Generic;
using System.Linq;
using System;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infraestructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1,10).Select( x => new Post{
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://images/{x}",
                UserId = x*2
            });

            return posts;
        }
    }
}