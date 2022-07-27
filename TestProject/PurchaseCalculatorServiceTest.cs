using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Application.PurchaseCalculator.Implementations;
using Domain.PurchasedProducts.Entities;
using Domain.Currencies.Entities;

namespace TestProject
{
    public class PurchaseCalculatorServiceTest
    {
        PurchaseCalculatorService purchaseCalculatorService = new PurchaseCalculatorService();

        List<PurchasedProduct> productsPurchasedList = new List<PurchasedProduct>()
        {
            new PurchasedProduct("Coca Cola",2, 500, "Canned Soda"),
            new PurchasedProduct("Coca Cola",1, 500, "Canned Soda"),
        };

        public IList<Currency> coinsList = new List<Currency>()
        {
            new Currency(20,"Colones", "CR", 500),
            new Currency(30,"Colones", "CR", 100),
            new Currency(50,"Colones", "CR", 50),
            new Currency(25,"Colones", "CR", 25),
        };

        [Fact]
        public void GetTotalPurchaseTest()
        {
            //arrange
            double expectedResult =1500;

            //act 
            double totalPurchaseAmount = purchaseCalculatorService.GetTotalPurchase(productsPurchasedList);

            //assert
            Assert.Equal(expectedResult, totalPurchaseAmount);
        }

        [Fact]
        public void GetTotalAmountTest()
        {
            //arrange
            double expectedResult = 16125;

            //act 
            double totalAmount = purchaseCalculatorService.GetTotalAmount(coinsList);

            //assert
            Assert.Equal(expectedResult, totalAmount);
        }
    }
}
