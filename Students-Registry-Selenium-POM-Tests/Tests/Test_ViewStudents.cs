using OpenQA.Selenium;
using Students_Registry_Selenium_POM_Tests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.Tests
{
    public class TestViewStudentPage : BaseTest
    {
        
        [Test]
        public void Test_ViewStudentsPage_Content()
        {
            var page = new ViewStudentPage(driver);
            page.Open();
            Assert.AreEqual("Students", page.GetPageTitle());
            Assert.AreEqual("Registered Students", page.GetPageHeadingText());          

            var students = page.GetRegistredStudents();

            foreach (string st in students)
            {
                Assert.IsTrue(st.IndexOf("(") > 0);
                Assert.IsTrue(st.LastIndexOf(")") == st.Length -1);
            }
        }

        [Test]
        public void Test_HomePage_Link()
        {
            var page = new ViewStudentPage(driver);
            page.Open();
            page.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());
        }

        [Test]
        public void Test_AddStudents_Link()
        {
            var page = new ViewStudentPage(driver);
            page.Open();
            page.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());
        }

        [Test]
        public void Test_ViewStudentPage_Link()
        {
            var page = new ViewStudentPage(driver);
            page.Open();
            page.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsOpen());
        }
     }
}
