using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite.Components
{
    public class Address : BaseClass
    {
        public Address(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AddressPage()
        {
            IWebElement button = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/app-checkout/div/div[1]/input"));
            button.SendKeys("Hyderabad");
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/app-checkout/div/form/input"));
            button2.Click();        
        }

    }
}
