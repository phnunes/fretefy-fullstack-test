using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
    {
        public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Cidade)
                   .WithMany(c => c.RegiaoCidade)
                   .HasForeignKey(r => r.CidadeId);

            builder.HasOne(r => r.Regiao)
                   .WithMany(re => re.RegiaoCidade)
                   .HasForeignKey(r => r.RegiaoId);
        }
    }
}
