using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using System.Reflection;
using SocialMedia.Infraestructure.Data.Configurations;
namespace SocialMedia.Infraestructure.Data
{
    public partial class SocialMediaContext : DbContext
    {
        public SocialMediaContext()
        {
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Publicacion> Publicacions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());

            modelBuilder.ApplyConfiguration(new PublicacionConfiguration());

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

        }
    }
}
