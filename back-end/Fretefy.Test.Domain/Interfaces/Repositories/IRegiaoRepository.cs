using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Entities.RequestModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        Task<IEnumerable<Regiao>> ListAsync();
        Task<RegiaoRequest> CreateAsync(RegiaoRequest regiao);
        Task<RegiaoRequest> UpdateAsync(RegiaoRequest regiao);

    }
}
