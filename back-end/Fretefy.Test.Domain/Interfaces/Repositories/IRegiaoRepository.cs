using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        IQueryable<Regiao> List();
        IQueryable<Regiao> Create(Regiao regiaoRequest);
        IQueryable<Regiao> Update(Regiao regiaoRequest);
    }
}
