using Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
