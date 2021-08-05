using System;

namespace SocialMedia.Core.DTOs
{
    public class PostDto
    {
        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}