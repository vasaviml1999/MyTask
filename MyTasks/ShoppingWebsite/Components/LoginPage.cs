using OpenQA.Selenium;
using System;
using System.Threading;
namespace ShoppingWebsite.Components
{
    class LoginPage : BaseClass
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Shop LoginPageMethod()
        {
            try
            {
                IWebElement Username = driver.FindElement(By.Id("username"));
                if (Username != null)
                {
                    Username.SendKeys("rahulshettyacademy");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("No Such Element Found");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No Such Element Found");
            }
            try
            {
                IWebElement Password = driver.FindElement(By.Id("password"));
                if (Password != null)
                {
                    Password.SendKeys("learning");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("No Such Element Found");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No Such Element Found");
            }
                IWebElement Login = driver.FindElement(By.Id("signInBtn"));
            if (Login != null)
            {
                Login.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("No Such Element Found");
            }
            return new Shop(driver);  
        }

    }
}