using Lib.Data;
using Lib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IProductRepository : IRepository<Product> {
        List<Product> GetProducts();
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { 
        }
        public List<Product> GetProducts() {
            var query = _dbcontext.Product;
            return query.ToList();
        }
    }
}
