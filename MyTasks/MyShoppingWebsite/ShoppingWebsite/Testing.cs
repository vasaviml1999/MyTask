using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using MyShoppingWebsite.

namespace MyShoppingWebsite
{
    [TestFixture]
    public class Testing : BaseClass
    {
        [Test]
        public void LoginPages()
        {
            ExtentTest Report1 = TestResult.CreateTest("Testing is started");
            var LoginPage = new LoginPage(driver);
            Report1.Log(Status.Info, "driver is  created");
            var Shop = LoginPage.LoginPageMethod();
            Report1.Log(Status.Pass, "Login page is working");
            var Product = Shop.ShopButton();
            Report1.Log(Status.Pass, "Shop button is working");
            var Home = Product.IphoneImage();
            Report1.Log(Status.Pass, "IPhone image is working as button");
            var Form = Home.HomeButton();
            Report1.Log(Status.Pass, "reached Home  Page");
            Form.Formpage();
            TestResult.Flush();
        }
        [Test]
        public void EndToEndTest1()
        {
            ExtentTest Report2 = TestResult.CreateTest("Testing is started");

            var LoginPAge = new LoginPage(driver);
            Report2.Log(Status.Info, "driver is created");
            var Shop = LoginPAge.LoginPageMethod();
            Report2.Log(Status.Pass, "Login page is working");
            var Product = Shop.ShopButton();
            Report2.Log(Status.Pass, "shop button is working");
            var checkout = Product.IphoneAdd();
            Report2.Log(Status.Pass, "iteam is  added ");
            var checkoutpage = checkout.CheckOutButton();
            Report2.Log(Status.Pass, "checkout button  is working");
            var address = checkoutpage.CheckOutShopping();
            Report2.Log(Status.Pass, "Reached the checkoutpage");
            address.AddressPage();
            Report2.Log(Status.Pass, "final page");
            TestResult.Flush();
        }
        [Test]
        public void EndToEndTest()
        {
            ExtentTest Report2 = TestResult.CreateTest("Testing is started");

            var LoginPAge = new LoginPage(driver);
            Report2.Log(Status.Info, "driver is created");
            var Shop = LoginPAge.LoginPageMethod();
            Report2.Log(Status.Pass, "Login page is working");
            var Product = Shop.ShopButton();
            Report2.Log(Status.Pass, "shop button is working");
            var checkout = Product.SamsungAdd();
            Report2.Log(Status.Pass, "iteam is  added ");
            var checkoutpage = checkout.CheckOutButton();
            Report2.Log(Status.Pass, "checkout button  is working");
            var address = checkoutpage.CheckOutShopping();
            Report2.Log(Status.Pass, "Reached the checkoutpage");
            address.AddressPage();
            Report2.Log(Status.Pass, "final page");
            TestResult.Flush();
        }
        [Test]
        public void EndToEndTest2()
        {
            ExtentTest Report2 = TestResult.CreateTest("Testing is started");
            var LoginPAge = new LoginPage(driver);
            Report2.Log(Status.Info, "driver is created");
            var Shop = LoginPAge.LoginPageMethod();
            Report2.Log(Status.Pass, "Login page is working");
            var Product = Shop.ShopButton();
            Report2.Log(Status.Pass, "shop button is working");
            var checkout = Product.NokiaAdd();
            Report2.Log(Status.Pass, "iteam is  added ");
            var checkoutpage = checkout.CheckOutButton();
            Report2.Log(Status.Pass, "checkout button  is working");
            var address = checkoutpage.CheckOutShopping();
            Report2.Log(Status.Pass, "Reached the checkoutpage");
            address.AddressPage();
            Report2.Log(Status.Pass, "final page");
            TestResult.Flush();
        }


        [Test]
        public void EndToEndTest3()
        {
            ExtentTest Report2 = TestResult.CreateTest("Testing is started");
            var LoginPAge = new LoginPage(driver);
            Report2.Log(Status.Info, "driver is created");
            var Shop = LoginPAge.LoginPageMethod();
            Report2.Log(Status.Pass, "Login page is working");
            var Product = Shop.ShopButton();
            Report2.Log(Status.Pass, "shop button is working");
            var checkout = Product.BlackbAdd();
            Report2.Log(Status.Pass, "iteam is  added ");
            var checkoutpage = checkout.CheckOutButton();
            Report2.Log(Status.Pass, "checkout button  is working");
            var address = checkoutpage.CheckOutShopping();
            Report2.Log(Status.Pass, "Reached the checkoutpage");
            address.AddressPage();
            Report2.Log(Status.Pass, "final page");
            TestResult.Flush();
        }
        [Test]
        public void EndtoEndTest4()
        {
            ExtentTest Report3 = TestResult.CreateTest("Testing is started");
            var LoginPage = new LoginPage(driver);
            var Shop = LoginPage.LoginPageMethod();
            var product = Shop.ShopButton();
            product.NokiaAdd();
            var Checkout = product.SamsungAdd();
            var checkoutpage = Checkout.CheckOutButton();
            checkoutpage.Remove();
            var address = checkoutpage.CheckOutShopping();
            address.AddressPage();
            TestResult.Flush();

        }
    }
}
