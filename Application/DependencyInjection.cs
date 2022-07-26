using Application.Products;
using Application.Products.Implementations;
using Application.PurchaseCalculator;
using Application.PurchaseCalculator.Implementations;
using Application.PurchasedProducts;
using Application.PurchasedProducts.Implementations;
using Application.Currencies;
using Application.Currencies.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IPurchasedProductService, PurchasedProductService>();
            services.AddTransient<IPurchaseCalculatorService, PurchaseCalculatorService>();
            services.AddTransient<ICurrencyService, CurrencyService>();
            return services;
        }
    }
}
