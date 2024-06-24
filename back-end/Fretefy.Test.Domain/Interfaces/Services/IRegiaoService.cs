using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        IEnumerable<Regiao> List();
        IEnumerable<Regiao> Create(Regiao regiaoRequest);
        IEnumerable<Regiao> Update(Regiao regiaoRequest);
    }
}
