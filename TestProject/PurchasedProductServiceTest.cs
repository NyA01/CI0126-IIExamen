using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Application.PurchasedProducts.Implementations;
using Domain.PurchasedProducts.Repositories;
using Domain.PurchasedProducts.Entities;
using LanguageExt;
using FluentAssertions;

namespace TestProject
{
    public class PurchasedProductServiceTest
    {

        List<PurchasedProduct> productsPurchasedList = new List<PurchasedProduct>()
        {
            new PurchasedProduct("Coca Cola",2, 500, "Canned Soda"),
        };

        PurchasedProduct newPurchasedProduct = new PurchasedProduct("Pepsi", 3, 600, "Canned Soda");

        [Fact]
        public void GetAllPurchasedProductsTest()
        {
            //arrange
            var mockPurchasedProductRepository = new Mock<IPurchasedProductRepository>();
            var productService = new PurchasedProductService(mockPurchasedProductRepository.Object);
            mockPurchasedProductRepository.Setup(repo => repo.GetAllPurchasedProducts()).Returns(productsPurchasedList.Where(e => e.Type == "Canned Soda"));
           
            //act
            var productsPurchasedListTest = productService.GetAllPurchasedProducts();
           
            //assert
            mockPurchasedProductRepository.Verify(repo => repo.GetAllPurchasedProducts(), Times.Once());
            productsPurchasedListTest.Count().Should().Equals(1);
        }

        [Fact]
        public void AddPurchasedProductTest()
        {
            //arrange
            var mockPurchasedProductRepository = new Mock<IPurchasedProductRepository>();
            var productService = new PurchasedProductService(mockPurchasedProductRepository.Object);
           
            mockPurchasedProductRepository.Setup(repo => repo.AddPurchasedProduct(newPurchasedProduct));

            //act
            productService.AddPurchasedProduct(newPurchasedProduct);

            //assert
            mockPurchasedProductRepository.Verify(repo => repo.AddPurchasedProduct(newPurchasedProduct), Times.Once());
        }
    }
}
