using OpenQA.Selenium;
using System;
using System.Threading;
namespace ShoppingWebsite.Components
{
    class Product : BaseClass
    {
        public Product(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Home IphoneImage()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[1]/div/a/img"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home SamsungImage()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[2]/div/a/img"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home NokiaImage()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[3]/div/a/img"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home BlackbImage()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[4]/div/a/img"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home IphoneName()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[1]/div/div[1]/h4/a"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home SamsungName()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[2]/div/div[1]/h4/a"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home NokiaName()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[3]/div/div[1]/h4/a"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public Home BlackName()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[4]/div/div[1]/h4/a"));
            Username.Click();
            Thread.Sleep(1000);
            return new Home(driver);
        }
        public CheckOut IphoneAdd()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[1]/div/div[2]/button"));
            Username.Click();
            Thread.Sleep(1000);
            return new CheckOut(driver);
        }
        public CheckOut SamsungAdd()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[2]/div/div[2]/button"));
            Username.Click();
            Thread.Sleep(1000);
            return new CheckOut(driver);
        }
        public CheckOut NokiaAdd()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[3]/div/div[2]/button"));
            Username.Click();
            Thread.Sleep(1000);
            return new CheckOut(driver);
        }
        public CheckOut BlackbAdd()
        {
            IWebElement Username = driver.FindElement(By.XPath(@"/html/body/app-root/app-shop/div/div/div[2]/app-card-list/app-card[4]/div/div[2]/button"));
            Username.Click();
            Thread.Sleep(1000);
            return new CheckOut(driver);
        }

    }
}
         