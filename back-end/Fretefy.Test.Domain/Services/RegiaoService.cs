using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public IEnumerable<Regiao> Create(Regiao regiaoRequest)
        {
            return _regiaoRepository.Create(regiaoRequest);
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List();
        }

        public IEnumerable<Regiao> Update(Regiao regiaoRequest)
        {
            return _regiaoRepository.Update(regiaoRequest);
        }
    }
}
