using Application.Products;
using Application.Products.Implementations;
using Application.PurchasedProducts;
using Application.PurchasedProducts.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IPurchasedProductService, PurchasedProductService>();
            return services;
        }
    }
}
