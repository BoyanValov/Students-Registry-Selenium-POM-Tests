using Students_Registry_Selenium_POM_Tests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.Tests
{
    public class TestHomePage : BaseTest
    {

        [Test]
        public void Test_HomePage_Content()
        {
            var page = new HomePage(driver);
            page.Open();

            Assert.AreEqual("MVC Example", page.GetPageTitle());
            Assert.AreEqual("Students Registry", page.GetPageHeadingText());
            page.GetStudentsCount();
        }

        [Test]
        public void Test_HomePage_Links()
        {
            var Homepage = new HomePage(driver);
            Homepage.Open();
            Homepage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());
        }

        [Test]
            public void Test_AddStudentPage_Link()
            {
                var Homepage = new HomePage(driver);
                Homepage.Open();
                Homepage.LinkAddStudentsPage.Click();
                Assert.IsTrue(new AddStudentPage(driver).IsOpen());
            }

        [Test]
        public void Test_ViewStudentPage_Link()
        {
            var Homepage = new HomePage(driver);
            Homepage.Open();
            Homepage.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsOpen());
        }
    }
}