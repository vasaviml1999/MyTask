using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite.Components
{
    public class Shop:BaseClass
    {
        public Shop(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal Product ShopButton()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-navbar/div/nav/ul/li[2]/a"));
            Username.Click();
            return new Product(driver);
        }
    }
}
