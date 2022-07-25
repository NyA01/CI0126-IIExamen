using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products.Entities;

namespace Domain.Products.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void UpdateProductStock(Product product);
    }
}
