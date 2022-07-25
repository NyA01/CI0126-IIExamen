using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Application.Products.Implementations;
using Domain.Products.Repositories;
using Domain.Products.Entities;
using LanguageExt;
using FluentAssertions;

namespace TestProject
{
    public class ProductServiceTest
    {

        List<Product> productsList = new List<Product>()
        {
            new Product(10,"Coca Cola", 500, "Canned Soda"),
            new Product(8,"Pepsi", 600, "Canned Soda"),
            new Product(10,"Fanta", 550, "Canned Soda"),
            new Product(15,"Sprite", 725, "Canned Soda"),
        };

        [Fact]
        public void GetAllProducts()
        {
            //arrange
            var mockProductRepository = new Mock<IProductRepository>();
            var productService = new ProductService(mockProductRepository.Object);
            mockProductRepository.Setup(repo => repo.GetAllProducts()).Returns(productsList.Where(e => e.Type == "Canned Soda"));

            //act
            var productsListTest = productService.GetAllProducts();

            //assert
            mockProductRepository.Verify(repo => repo.GetAllProducts(),Times.Once());
            productsListTest.Count().Should().Equals(4);

        }
    }
}
