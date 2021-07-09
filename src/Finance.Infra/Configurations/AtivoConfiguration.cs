using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Finance.Infra.Configuration
{
    public class AtivoConfiguration : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
                       builder.ToTable("Ativos");
                       builder.HasKey(p => p.Id);
                       builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
                       builder.Property(p => p.DataInclusao).HasColumnType("DATETIME").IsRequired();
                       //builder.Property(p => p.DataInclusao).HasDefaultValue("GEDATE()").ValueGeneratedOnAdd();
                       builder.HasOne(p => p.Categoria)
                       .WithMany()
                       .HasForeignKey(p => p.IdCategoria)
                       .OnDelete(DeleteBehavior.Restrict);

        }
    }
}