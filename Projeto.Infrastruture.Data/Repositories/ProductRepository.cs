using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces;
using Projeto.Infrastruture.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infrastruture.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly ProjetoContext _context;
        public ProductRepository(ProjetoContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return
                _context.Products.Where(p => p.ProductName == name);
        }
    }
}
