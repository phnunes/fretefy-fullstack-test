using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities.RequestModels
{
    public class RegiaoRequest : Regiao
    {
        public IList<string> ListaCidades { get; set; }
    }
}
