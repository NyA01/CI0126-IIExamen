using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Application.Currencies.Implementations;
using Domain.Currencies.Repositories;
using Domain.Currencies.Entities;
using LanguageExt;
using FluentAssertions;

namespace TestProject
{
    public class CurrencyServiceTest
    {

        public IList<Currency> coinsList = new List<Currency>()
        {
            new Currency(20,"Colones", "CR", 500),
            new Currency(30,"Colones", "CR", 100),
            new Currency(50,"Colones", "CR", 50),
            new Currency(25,"Colones", "CR", 25),
        };

        [Fact]
        public void GetAllCoinsTest()
        {
            //arrange
            var mockCurrencyRepository = new Mock<ICurrencyRepository>();
            var currencyService = new CurrencyService(mockCurrencyRepository.Object);
            mockCurrencyRepository.Setup(repo => repo.GetAllCoins()).Returns(coinsList.Where(e => e.Name == "Colones"));

            //act
            var currencyListTest = currencyService.GetAllCoins();

            //assert
            mockCurrencyRepository.Verify(repo => repo.GetAllCoins(), Times.Once());
            currencyListTest.Count().Should().Equals(4);

        }
    }
}