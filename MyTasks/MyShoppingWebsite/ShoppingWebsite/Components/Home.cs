using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite.Components
{
    public class Home:BaseClass
    {
        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Form HomeButton()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-navbar/div/nav/ul/li[1]/a"));
            Username.Click();
            Thread.Sleep(1000);
            return new Form(driver);
        }

    }
}
