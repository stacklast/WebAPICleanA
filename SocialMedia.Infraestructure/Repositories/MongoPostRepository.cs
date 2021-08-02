using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Infraestructure.Repositories
{
    public class MongoPostRepository: IPostRepository
    {
        public async Task< IEnumerable< Post > > GetPosts()
        {
            var posts = Enumerable.Range(1,10).Select( x => new Post{
                PostId = x,
                Description = $"Description Mongo {x}",
                Date = DateTime.Now,
                Image = $"https://images/{x}",
                UserId = x*2
            });

            await Task.Delay(10);

            return posts;
        }
    }
}