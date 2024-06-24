using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : IEntity
    {
        public RegiaoCidade() { }
        public RegiaoCidade(Regiao regiao, string nomeCidade, int regiaoId) 
        { 
            Id = Guid.NewGuid();
            Regiao = regiao;
            RegiaoId = regiaoId;
            NomeCidade = nomeCidade;
        }

        public RegiaoCidade( string nomeCidade, int regiaoId)
        {
            Id = Guid.NewGuid();
            RegiaoId = regiaoId;
            NomeCidade = nomeCidade;
        }
        public Guid Id { get; set; }
        public virtual int RegiaoId { get; set; }
        public virtual Regiao Regiao { get; set; }
        public string NomeCidade { get; set; }
    }
}
