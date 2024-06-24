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

               new RegiaoCidade("Rio Branco", 5),
               new RegiaoCidade("Manaus", 5),
               new RegiaoCidade("Goiânia", 5),
               new RegiaoCidade("Belém", 5),
               new RegiaoCidade("Palmas", 5),
               new RegiaoCidade("Porto Velho", 5),

               new RegiaoCidade("Maceió", 4),
               new RegiaoCidade("Macapá", 4),
               new RegiaoCidade("Salvador", 4),
               new RegiaoCidade("Fortaleza", 4),
               new RegiaoCidade("São Luís", 4),
               new RegiaoCidade("Cuiabá", 4),
               new RegiaoCidade("João Pessoa", 4),
               new RegiaoCidade("Recife", 4),
               new RegiaoCidade("Teresina", 4),
               new RegiaoCidade("Aracaju", 4),
               new RegiaoCidade("Boa Vista", 4),
               new RegiaoCidade("Natal", 4),

               new RegiaoCidade("Brasília", 3),
               new RegiaoCidade("Cuiabá", 3),
               new RegiaoCidade("Campo Grande", 3),

               new RegiaoCidade("Vitória", 2),
               new RegiaoCidade("Belo Horizonte", 2),
               new RegiaoCidade("Rio de Janeiro", 2),
               new RegiaoCidade("São Paulo", 2),

               new RegiaoCidade("Curitiba", 1),
               new RegiaoCidade("Florianópolis", 1),
               new RegiaoCidade("Porto Alegre", 1)
               );
        }

    }
}
