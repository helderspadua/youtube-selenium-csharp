using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouTube.End2End.Selenium.PageObjects
{
    class VideoPage
    {
        private IWebDriver driver;

        public VideoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickShareButton()
        {
            driver.FindElements(By.CssSelector(".style-scope.ytd-menu-renderer.force-icon-button.style-default.size-default"))
                .First()
                .Click();
        }

        internal Uri GetSharingUrl()
        {
            var url = driver.FindElement(By.Id("share-url")).GetAttribute("value");
           
            return new Uri(url);
        }
    }
}
