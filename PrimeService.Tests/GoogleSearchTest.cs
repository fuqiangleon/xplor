using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumTests
{
    public class GoogleSearchTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoogleSearch()
        {
            driver.Navigate().GoToUrl("https://www.bing.com");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Jenkins Selenium Test");
            searchBox.Submit();
            Assert.IsTrue(driver.Title.Contains("Jenkins Selenium Test"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
