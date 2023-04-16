using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Registry_Selenium_POM_Tests.PageObjects
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl =>
            "https://studentregistry.softuniqa.repl.co/add-student";
        public void AddStudent(string name, string email)
        {
            this.FieldName.SendKeys(name);
            this.FieldEmail.SendKeys(email);
            this.ButtonSubmit.Click();
        }
        public string GetErrorMsg()
        {
            var errormsg = this.ElementErrorMsg.Text;
            return errormsg;
        }

        public string fieldName()
        {
            var field1 = this.FieldName.Text;
            return field1;
        }

        public string fieldEmail()
        {
            var field2 = this.FieldEmail.Text;
            return field2;
        }

        public string ButtonText()
        {
            var buttontext = this.ButtonSubmit.Text;
            return buttontext;
        }
    }
}
