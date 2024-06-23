using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : IEntity
    {
        public RegiaoCidade() { }
        public RegiaoCidade(int idRegiao, string nomeCidade) 
        { 
            Id = Guid.NewGuid();
            IdRegiao = idRegiao;
            NomeCidade = nomeCidade;
        }
        public Guid Id { get; set; }
        public int IdRegiao { get; set; }
        public string NomeCidade { get; set; }
    }
}
