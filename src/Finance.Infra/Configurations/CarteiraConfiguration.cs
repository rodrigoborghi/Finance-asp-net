using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Finance.Infra.Configuration
{
    public class CarteiraConfiguration : IEntityTypeConfiguration<Carteira>
    {
        public void Configure(EntityTypeBuilder<Carteira> builder)
        {
                       builder.ToTable("Carteiras");
                       builder.HasKey(p => p.Id);
                       builder.Property(p => p.DataCriacao).HasColumnType("DATETIME").IsRequired();
                      //  builder.Property(p => p.DataCriacao).HasDefaultValue("GEDATE()").ValueGeneratedOnAdd();
                       builder.HasOne(x => x.Corretora)
                        .WithMany()
                        .HasForeignKey(p => p.IdCorretora).IsRequired();
                       builder.HasOne(p => p.Cliente)
                        .WithMany()
                        .HasForeignKey(p => p.IdCliente).IsRequired();
                       builder.HasMany(p => p.AtivosCarteira)
                        .WithOne(p => p.Carteira).IsRequired()
                        .OnDelete(DeleteBehavior.Cascade).IsRequired();

        }
    }
}