using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShoppingWebsite.Components
{
    public class Form :BaseClass
    {
        public Form(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Formpage()
        {
            IWebElement Name = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[1]/input"));
            Name.SendKeys("abc");
            Thread.Sleep(1000);
            IWebElement Email = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[2]/input"));
            Email.SendKeys("abc@gmail.com");
            Thread.Sleep(1000);
            IWebElement Password = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[3]/input"));
            Password.SendKeys("nani");
            Thread.Sleep(1000);
            IWebElement CheckBox = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[4]/input"));
            CheckBox.Click();
            Thread.Sleep(1000);
            IWebElement DropDown = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[5]/select"));
            DropDown.Click();
            Thread.Sleep(1000);
            IWebElement EmpStatus = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[6]/div[2]/input"));
            EmpStatus.Click();
            Thread.Sleep(1000);
            IWebElement DateOFBirth = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[7]/input"));
            DateOFBirth.Click();
            Thread.Sleep(1000);
            IWebElement date = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/div[7]/input"));
            date.SendKeys("01/04/2022");
            Thread.Sleep(1000);
            IWebElement Submit = driver.FindElement(By.XPath(@"/html/body/app-root/form-comp/div/form/input"));
            Submit.Click();
            Thread.Sleep(1000);
        }
    }
}
