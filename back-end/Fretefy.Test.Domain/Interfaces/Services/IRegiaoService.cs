using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Entities.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        Task<IEnumerable<Regiao>> ListAsync();
        Task<RegiaoRequest> CreateAsync(RegiaoRequest regiaoRequest);
        Task<RegiaoRequest> UpdateAsync(RegiaoRequest regiaoRequest);
    }
}
