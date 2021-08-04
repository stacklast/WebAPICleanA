using System.Collections.Generic;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Publicacion>> GetPosts();

        Task<Publicacion> GetPost(int id);

        Task InsertPost(Publicacion post);
    }
}