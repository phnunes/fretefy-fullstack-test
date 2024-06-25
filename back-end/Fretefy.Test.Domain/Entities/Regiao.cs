using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao
    {
        public Regiao() { }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<RegiaoCidade> RegiaoCidade { get; set; }
    }
}
