using Domain.Currencies.Repositories;
using Domain.Products.Repositories;
using Domain.PurchasedProducts.Repositories;
using Infrastructure.Currencies.Repositories;
using Infrastructure.Products;
using Infrastructure.Products.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            //services.AddDbContext<ProductDBContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPurchasedProductRepository, PurchasedProductRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            return services;
        }
    }
}
