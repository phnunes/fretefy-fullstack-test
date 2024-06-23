using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Regiao(1, "Sul"),
                new Regiao(2, "Sudeste"),
                new Regiao(3, "Centro-Oeste"),
                new Regiao(4, "Nordeste"),
                new Regiao(5, "Norte")
                );
        }
    }
}
