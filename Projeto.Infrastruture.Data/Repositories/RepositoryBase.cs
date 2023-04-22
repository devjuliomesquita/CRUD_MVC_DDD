using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Interfaces;
using Projeto.Infrastruture.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infrastruture.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ProjetoContext _context;
        public RepositoryBase(ProjetoContext context)
        {
            _context = context;
        }
        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();                
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return
                _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return
                _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
