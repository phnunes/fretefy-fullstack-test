using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Nome)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.HasIndex(r => r.Nome)
                   .IsUnique();

            builder.HasMany(r => r.RegiaoCidade)
                   .WithOne(c => c.Regiao)
                   .HasForeignKey(c => c.RegiaoId);
        }
    }
}
