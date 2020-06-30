using FluentAssertions;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YouTube.End2End.Selenium.Driver;
using YouTube.End2End.Selenium.PageObjects;

namespace YouTube.End2End.Selenium.Tests
{
    class VideoPageTests
    {
        [Test]
        [TestCase("Chrome")]
        public void WhenClcickingShareShouldSeeAvailableLink(string browser) {

            var driver =  DriverFactory.Create(browser, "https://www.youtube.com/results?search_query=tibia");

            SearchPage searchPage = new SearchPage(driver);
            searchPage.AccessFirstVideo();

            VideoPage videoPage = new VideoPage(driver);
            videoPage.ClickShareButton();
            Uri url =  videoPage.GetSharingUrl();

            url.Should().NotBeNull();
            url.Host.Should().Be("youtu.be");
            url.Scheme.Should().Be("https");
        }
    }
}
