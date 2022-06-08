using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite.Components
{
    public class CheckOut : BaseClass
    {
        public CheckOut(IWebDriver driver)
        {
            this.driver = driver;
        }
        public CheckOutPage CheckOutButton()
        {
            IWebElement button = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/nav/div/div/ul/li/a"));
            button.Click();
            Thread.Sleep(1000);
            return new CheckOutPage(driver);
        }

    }
}
