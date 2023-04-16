using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Students_Registry_Selenium_POM_Tests.PageObjects;

namespace Students_Registry_Selenium_POM_Tests.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           this.driver.Quit();
        }

        
    }
}