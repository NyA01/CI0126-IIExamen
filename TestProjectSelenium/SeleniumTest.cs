using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProjectSelenium
{
	public class Tests
	{
		IWebDriver driver;

		[SetUp]
		public void startBrowser()
		{
			driver = new ChromeDriver();
		}

		[Test]
		public void IncompleteProductToChooseForm()
		{
			IWebElement addToPayButton;
			IWebElement messageError = null;

			// Arrange
			string URL = "https://localhost:44359/";
			driver.Manage().Window.Maximize();
			driver.Url = URL;

			//Act
			Thread.Sleep(2000);
			addToPayButton = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-grid.mud-grid-spacing-xs-3.mud-grid-justify-xs-flex-start > div:nth-child(2) > div.mud-toolbar.gap-4 > button > span"));
			addToPayButton.Click();
			Thread.Sleep(2000);
			messageError = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-grid.mud-grid-spacing-xs-3.mud-grid-justify-xs-flex-start > div:nth-child(2) > form > div:nth-child(2) > div.mud-select > div"));

			//Assert
			Thread.Sleep(2000);
			Assert.IsTrue(messageError != null);
		}
	}
}