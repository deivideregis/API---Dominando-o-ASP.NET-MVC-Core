using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Mappings
{
    public class FilmesMapping : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Titulo)
                .IsRequired()
                .HasColumnType("varchar(60)");

            builder.Property(p => p.DataLancamento)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.Genero)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Genero)
                .IsRequired()
                .HasColumnType("int");

            builder.ToTable("Filmes");
        }
    }
}
