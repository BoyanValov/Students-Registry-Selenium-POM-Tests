using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.PageObjects
{
    public class ViewStudentPage : BasePage
    {

        public ViewStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl =>
            "https://studentregistry.softuniqa.repl.co/students";

        public ReadOnlyCollection<IWebElement> ListItemsStudents =>
            driver.FindElements(By.CssSelector("body > ul > li "));

        public string[] GetRegistredStudents()
        {
            var elementsStudents = this.ListItemsStudents.Select(s => s.Text).ToArray();
            return elementsStudents;
        }
    }
}
