using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Finance.Infra.Configuration
{
    public class CorretoraConfiguration : IEntityTypeConfiguration<Corretora>
    {
        public void Configure(EntityTypeBuilder<Corretora> builder)
        {
                       builder.ToTable("Corretoras");
                       builder.HasKey(p => p.Id);
                       builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
                       builder.Property(p => p.DataCriacao).HasColumnType("DATETIME").IsRequired();
                      // builder.Property(p => p.DataCriacao).HasDefaultValue("GEDATE()").ValueGeneratedOnAdd();
                   

        }
    }
}