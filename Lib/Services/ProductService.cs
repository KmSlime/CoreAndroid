using Lib.Entity;
using Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Services
{
    public class ProductService
    {
        private ApplicationDbContext dbContext;
        private IProductRepository productRepository;

        public ProductService(ApplicationDbContext dbContext, IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            this.dbContext = dbContext;
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void InsertProduct(Product pd) {
            dbContext.Add(pd);
            Save();
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
