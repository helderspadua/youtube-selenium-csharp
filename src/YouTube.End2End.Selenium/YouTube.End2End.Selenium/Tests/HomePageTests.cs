using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Linq;
using YouTube.End2End.Selenium.Driver;
using YouTube.End2End.Selenium.PageObjects;

namespace YouTube.End2End.Selenium.Tests
{
    public class HomePageTests
    {
        private IWebDriver driver;
        private ChromeDriver chromeDriver;

        [SetUp]
        public void Setup()
        {
            //driver = DriverFactory.Create();
            //this.chromeDriver = DriverFactory.BuildChromeDriver();
        }

        [Test]
        [TestCase("Chrome")]
        //[TestCase("Firefox")]
        [TestCase("edge")]
        // given I am at the youtube home page
        // when I search for a title
        // then should see videos related to the title
        public void WhenSearchinForATitleShouldReturnAnyVideoRelated(string browser)
        {
            this.driver = DriverFactory.Create(browser);

            HomePage homePage = new HomePage(driver);
            homePage.SearchTitle("Tibia");

            SearchPage searchPage = new SearchPage(driver);
            searchPage.HasAvailableTitles("Tibia").Should().BeTrue();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }
    }
}