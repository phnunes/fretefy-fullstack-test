using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Entities.RequestModels;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite.Design.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly TestDbContext _context;
        private readonly ICidadeRepository _cidadeRepository;

        public RegiaoRepository(TestDbContext context, ICidadeRepository cidadeRepository)
        {
            _context = context;
            _cidadeRepository = cidadeRepository;
        }

        public async Task<RegiaoRequest> CreateAsync(RegiaoRequest regiaoRequest)
        {
            try
            {
                if (regiaoRequest is null)
                {
                    throw new ArgumentNullException("Parâmetro null.");
                }

                if (_context.Regiao.Any(r => r.Nome == regiaoRequest.Nome))
                {
                    throw new ArgumentException("Região já cadastrada.");
                }
              
                var novaRegiao = _context.Regiao.Add(regiaoRequest);

                foreach (var cidade in regiaoRequest.ListaCidades)
                {
                    var cidadeDb = _cidadeRepository
                               .List()
                               .Where(c => c.Nome == cidade)
                               .FirstOrDefault();

                    var novaRegiaoCidade = new RegiaoCidade()
                    {
                        CidadeId = cidadeDb.Id,
                        RegiaoId = regiaoRequest.Id
                    };

                    _context.RegiaoCidade.Add(novaRegiaoCidade);
                }

                await _context.SaveChangesAsync();

                return regiaoRequest;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar Região. Exception: " + ex.InnerException);
            }
        }

        public async Task<IEnumerable<Regiao>> ListAsync()
        {
            var listRegiao = await _context.Regiao
                                    .Include(reg => reg.RegiaoCidade)
                                    .ThenInclude(c => c.Cidade)
                                    .AsNoTracking()
                                    .ToListAsync();
            return listRegiao;
        }

        public async Task<RegiaoRequest> UpdateAsync(RegiaoRequest regiaoRequest)
        {
            try
            {
                var regiaoOnDb = await _context.Regiao
                                    .Include(r => r.RegiaoCidade)
                                    .FirstOrDefaultAsync(r => r.Id == regiaoRequest.Id);

                if (regiaoOnDb is null)
                    throw new ArgumentException("Região não existe no banco.");

                regiaoOnDb.Nome = regiaoRequest.Nome;
                regiaoOnDb.Status = regiaoRequest.Status;

                foreach (var cidade in regiaoRequest.ListaCidades)
                {
                    var cidadeDb = _cidadeRepository
                               .List()
                               .Where(c => c.Nome == cidade)
                               .FirstOrDefault();

                    var novaRegiaoCidade = new RegiaoCidade()
                    {
                        CidadeId = cidadeDb.Id,
                        RegiaoId = regiaoRequest.Id
                    };
                    
                    _context.RegiaoCidade.Add(novaRegiaoCidade);
                }

                await _context.SaveChangesAsync();
                
                return regiaoRequest;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Região. Exception: " + ex.InnerException);
            }
        }
    }
}
