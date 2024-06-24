using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao
    {
        public Regiao() { }
        public Regiao(int id, string nome) 
        { 
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<RegiaoCidade> RegiaoCidade { get; set; }
    }
}
