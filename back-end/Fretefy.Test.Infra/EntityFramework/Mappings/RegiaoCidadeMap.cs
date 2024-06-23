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
            builder.HasData(
               new RegiaoCidade(5, "Rio Branco"),
               new RegiaoCidade(5, "Manaus"),
               new RegiaoCidade(5, "Goiânia"),
               new RegiaoCidade(5, "Belém"),
               new RegiaoCidade(5, "Palmas"),
               new RegiaoCidade(5, "Porto Velho"),

               new RegiaoCidade(4, "Maceió"),
               new RegiaoCidade(4, "Macapá"),
               new RegiaoCidade(4, "Salvador"),
               new RegiaoCidade(4, "Fortaleza"),
               new RegiaoCidade(4, "São Luís"),
               new RegiaoCidade(4, "Cuiabá"),
               new RegiaoCidade(4, "João Pessoa"),
               new RegiaoCidade(4, "Recife"),
               new RegiaoCidade(4, "Teresina"),
               new RegiaoCidade(4, "Aracaju"),
               new RegiaoCidade(4, "Boa Vista"),
               new RegiaoCidade(4, "Natal"),

               new RegiaoCidade(3, "Brasília"),
               new RegiaoCidade(3, "Cuiabá"),
               new RegiaoCidade(3, "Campo Grande"),

               new RegiaoCidade(2, "Vitória"),
               new RegiaoCidade(2, "Belo Horizonte"),
               new RegiaoCidade(2, "Rio de Janeiro"),
               new RegiaoCidade(2, "São Paulo"),

               new RegiaoCidade(1, "Curitiba"),
               new RegiaoCidade(1, "Florianópolis"),
               new RegiaoCidade(1, "Porto Alegre")
               );
        }

    }
}
