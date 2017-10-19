using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SimpleTest
{
    public class SimpleTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void OpenDou() {
            
            driver.Url = "https://dou.ua/";

            Assert.True(driver.Title.Contains("DOU"), "Title is not correct");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
