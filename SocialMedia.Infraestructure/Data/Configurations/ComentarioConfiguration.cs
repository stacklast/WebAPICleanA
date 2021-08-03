using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;
namespace SocialMedia.Infraestructure.Data.Configurations
{
    public class ComentarioConfiguration: IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
             builder.HasKey(e => e.IdComentario);

                builder.ToTable("Comentario");

                builder.Property(e => e.IdComentario).ValueGeneratedNever();

                builder.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                builder.Property(e => e.Fecha).HasColumnType("datetime");

                builder.HasOne(d => d.IdPublicacionNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.IdPublicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comentario_Publicacion");

                builder.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comentario_Usuario");
        }
    }
}