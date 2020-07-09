using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouTube.End2End.Selenium.PageObjects
{
    class GoogleSignInPage
    {
        IWebDriver driver;
        public GoogleSignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void SignIn(string userName, string userPassword)
        {
            driver.FindElement(By.Id("identifierId")).SendKeys(userName);

            driver.FindElement(By.Id("identifierNext")).Click();

            driver.FindElement(By.Name("password")).SendKeys(userPassword);

            driver.FindElement(By.Id("passwordNext")).Click();

        }
    }
}
