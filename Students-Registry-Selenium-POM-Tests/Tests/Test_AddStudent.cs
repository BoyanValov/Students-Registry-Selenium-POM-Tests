using OpenQA.Selenium.DevTools.V109.HeapProfiler;
using Students_Registry_Selenium_POM_Tests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.Tests
{
    public class TestAddStudentPage : BaseTest
    {
        [Test]
        public void Test_AddStudentPage_Content()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            Assert.AreEqual("Add Student", page.GetPageTitle());
            Assert.AreEqual("Register New Student", page.GetPageHeadingText());
            Assert.IsEmpty(page.fieldName());
            Assert.IsEmpty(page.fieldEmail());
            Assert.AreEqual(page.ButtonText(), "Add");
        }

        [Test]
        public void Test_TestAddStudentPage_Links()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            page.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());
            page.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());
            page.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsOpen());
        }

        [Test]
        public void Test_TestAddStudentPage_AddValidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "New student" + DateTime.Now.Ticks;
            string email = "email" + DateTime.Now.Ticks + "@email.com";
            page.AddStudent(name, email);
            page.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentPage(driver).IsOpen());
            var studentsPage = new ViewStudentPage(driver);
            var students = studentsPage.GetRegistredStudents();
            Assert.That((name + " " + "(" + email + ")"), Is.EqualTo(students.Last()));
            //Assert.IsTrue(students.Contains(name + email));
        }

        [Test]
        public void Test_TestAddStudentPage_AddInvalidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = " ";
            string email = "email" + DateTime.Now.Ticks + "@email.com";
            page.AddStudent(name, email);
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());
            var Addstudents = new AddStudentPage(driver);
            var errormsg = Addstudents.GetErrorMsg();
            Assert.IsTrue(errormsg.Contains("Cannot add student"));

        }
    }
}
