using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouTube.End2End.Selenium.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void SearchTitle(string title)
        {
            IWebElement searchBox = driver.FindElement(By.Id("search-input"))
                .FindElement(By.TagName("input"));
            searchBox.Click();
            searchBox.SendKeys(title);

            IWebElement searchBtn = driver.FindElement(By.Id("search-icon-legacy"));
            searchBtn.Click();

        }

        internal void ClickSignIn()
        {
            driver.FindElements(By.TagName("a"))
            .First(a => (a.GetAttribute("href") ?? "").Contains("accounts.google.com"))
            .Click();
        
        }

        internal bool HasAvatarButton()
        {
            return driver.FindElements(By.Id("avatar-btn")).Any();
        }

        internal bool HasNotificationButton()
        {
            return driver.FindElements(By.TagName("ytd-notification-topbar-button-renderer")).Any();
        }
    }
}
