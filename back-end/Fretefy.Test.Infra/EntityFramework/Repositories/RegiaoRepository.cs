using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private DbSet<Regiao> _dbSet;
        private DbSet<Cidade> _dbSetCity;

        public RegiaoRepository(DbContext dbContext)
        {
            _dbSet = dbContext.Set<Regiao>();
        }

        public IQueryable<Regiao> Create(Regiao regiaoRequest)
        {
            if (regiaoRequest == null)
            {
                throw new ArgumentNullException("Parâmetro nulo passado para o endpoint");
            }
            var regiaoEntity = _dbSet.Add(regiaoRequest);
            regiaoEntity.Context.SaveChanges();

            return _dbSet.AsQueryable();
        }

        public IQueryable<Regiao> List()
        {
            _dbSet.Include(x => x.RegiaoCidade).ToList();
            return _dbSet.AsQueryable();
        }

        public IQueryable<Regiao> Update(Regiao regiaoRequest)
        {
            if (regiaoRequest == null)
            {
                throw new ArgumentNullException("Parâmetro nulo passado para o endpoint");
            }

            var regiaoFind = _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{regiaoRequest.Nome}%"));
            if (regiaoFind == null)
            {
                throw new DataException("Região não encontrada");
            }

            var regiaoEntity = _dbSet.Update(regiaoRequest);
            regiaoEntity.Context.SaveChanges();

            return _dbSet.AsQueryable();
        }
    }
}
