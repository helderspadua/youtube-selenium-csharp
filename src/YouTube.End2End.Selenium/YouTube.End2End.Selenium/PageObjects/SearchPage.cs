using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace YouTube.End2End.Selenium.PageObjects
{
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal bool HasAvailableTitles(String title)
        {

            var availableTitlesElements = driver.FindElements(By.ClassName("title-and-badge"))
                .Select(t => t.FindElement(By.TagName("a")))
                .Select(t => t.GetAttribute("title"));
              
                

            return availableTitlesElements.Any(t => t.Contains(title));
                
            
        }
    }
}
