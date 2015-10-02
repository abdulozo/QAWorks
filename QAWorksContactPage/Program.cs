using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace QAWorksContactPage
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://www.qaworks.com/contact.aspx";

            var nameBox = driver.FindElement(By.Id("ctl00_MainContent_NameBox"));
            nameBox.SendKeys("j.Bloggs   6");

            var emailBox = driver.FindElement(By.Id("ctl00_MainContent_EmailBox"));
            emailBox.SendKeys("j.Bloggs@qaworks.com");

            var messageBox = driver.FindElement(By.Id("ctl00_MainContent_MessageBox"));
            messageBox.SendKeys("please contact me I want to find out more");

            var submitButton = driver.FindElement(By.XPath("/html/body/form/div[3]/div[2]/div[2]/div[6]/input"));
            submitButton.Click();

        }

        
    }
}
