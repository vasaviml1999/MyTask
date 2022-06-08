using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite.Components
{
    public class CheckOutPage : BaseClass
    {
        public CheckOutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Remove()
        {
            IWebElement removebutton = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div/table/tbody/tr[1]/td[5]/button"));
            removebutton.Click();
        }
        public void ContinueShopping()
        {
            IWebElement button = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div/table/tbody/tr[2]/td[4]/button"));
            button.Click();
            Thread.Sleep(1000);
        }
        public Address CheckOutShopping()
        {
            IWebElement button = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div[1]/div/div/table/tbody/tr[3]/td[5]/button"));
            button.Click();
            Thread.Sleep(1000);
            return new Address(driver);
        }
    }
}
