using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Entities.RequestModels;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<RegiaoRequest> CreateAsync(RegiaoRequest regiaoRequest)
        {
            return await _regiaoRepository.CreateAsync(regiaoRequest);
        }

        public async Task<IEnumerable<Regiao>> ListAsync()
        {
            return await _regiaoRepository.ListAsync();
        }

        public async Task<RegiaoRequest> UpdateAsync(RegiaoRequest regiaoRequest)
        {
            return await _regiaoRepository.UpdateAsync(regiaoRequest);
        }
    }
}
