using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Finance.Infra.Configuration
{
     public class AtivosCarteiraConfiguration : IEntityTypeConfiguration<AtivosCarteira>
    {
        public void Configure(EntityTypeBuilder<AtivosCarteira> builder)
        {
            builder.ToTable("AtivosCarteira");
                       builder.HasKey(p => p.Id);
                       builder.Property(p => p.Quantidade).HasColumnType("INT").IsRequired();
                       builder.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();
                       builder.Property(p => p.DataCriacao).HasColumnType("DATETIME").IsRequired();
                       builder.Property(p => p.delete).HasColumnType("CHAR(1)").IsRequired();
                       builder.Property(p => p.DataVenda).HasColumnType("DATETIME");
                       
        }
    }
}