using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace YouTube.End2End.Selenium.Driver
{
    internal class DriverFactory
    {
        internal static IWebDriver Create(string browser)
        {
            IWebDriver driver;

            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "Firefox")
            {
                driver = new FirefoxDriver();

            }
            else if (browser == "edge")
            {
                driver = new EdgeDriver();
            }
            else
            {
                throw new Exception("Browser not supported");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.youtube.com/");

            return driver;
        }

    }
}