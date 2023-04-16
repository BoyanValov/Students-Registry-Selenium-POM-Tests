using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Fetch;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.PageObjects
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        public virtual string PageUrl { get; }
        public IWebElement LinkHomePage =>
            driver.FindElement(By.XPath("//a[contains(., 'Home')]"));
        public IWebElement LinkViewStudentPage =>
            driver.FindElement(By.XPath("//a[contains(., 'View Students')]"));
        public IWebElement LinkAddStudentsPage =>
            driver.FindElement(By.XPath("//a[contains(.,'Add Student')]"));
        public IWebElement ElementTextHeading =>
            driver.FindElement(By.CssSelector("body > h1"));
        public IWebElement ElementErrorMsg =>
            driver.FindElement(By.CssSelector("body > div"));
        public IWebElement FieldName =>
            driver.FindElement(By.CssSelector("input#name"));
        public IWebElement FieldEmail =>
            driver.FindElement(By.CssSelector("input#email"));
        public IWebElement ButtonSubmit =>
            driver.FindElement(By.XPath("//button[contains(.,'Add')]"));

        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeadingText()
        {
            return ElementTextHeading.Text; //Page<->Text
        }
    }
    
    
}
