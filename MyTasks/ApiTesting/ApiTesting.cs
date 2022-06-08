using RestSharp;
using NUnit.Framework;
using System.Net;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

using System;
namespace MyTask.ApiTesting
{
    [TestFixture]
    public class ApiTesting : Data
    {
        public ExtentReports TestResult { get; private set; }
        [OneTimeSetUp]
        public void ExtentStart()
        {
            TestResult = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\MyTask\MyTasks\ApiTesting\ExtentReport\index.html");
            TestResult.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            TestResult.Flush();
        }
        [Test]
        public void Postuser()
        {
            ExtentTest Post = TestResult.CreateTest("PostUser");
            var client = new RestClient("https://reqres.in/api");
            var req = new RestRequest("users", Method.POST);
            var body = new Data
            { name = "morpheus", job = "Tester" };
            req.AddJsonBody(body);
            var result = client.Post(req);
            req.AddParameter("application/json", body, ParameterType.RequestBody);
            Console.WriteLine((int)result.StatusCode);
            Console.WriteLine(result.StatusCode.ToString() + " " + result.Content.ToString());
            Post.Log(Status.Pass, "Post method is running");
            TestResult.Flush();
        }
        [TestCase("user", 65883, "Vasavi", "Apitester")]
        [TestCase("user", 67890, "Nani", "Tester")]
        [TestCase("user", 65432,"Bob","Developer")]
        public void putuser(string user, int id, string Name, string Job)
        {
            ExtentTest Put = TestResult.CreateTest("PutUser");
            var client = new RestClient("https://reqres.in/api");
            var req = new RestRequest($"{user}/{id}", Method.PUT);
            var body = new Data { name = Name, job = Job };
            req.AddJsonBody(body);   
            var res = client.Put(req);
            if (res.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Successfully Updated");
            }
            Console.WriteLine((int)res.StatusCode);
            Console.WriteLine("Content-Type : " + res.ContentType);
            Console.WriteLine(res.StatusCode.ToString() + " " + res.Content.ToString());
            Put.Log(Status.Pass, "Put method is running");
            TestResult.Flush();
        }
        [Test]
        public void getuser()
        {
            ExtentTest Get = TestResult.CreateTest("GetUser");
            var restClient = new RestClient("https://reqres.in/api");
            var restRequest = new RestRequest("users/2", Method.GET);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse restResponse = restClient.Get(restRequest);
            Console.WriteLine(restResponse.Content.ToString());
            Console.WriteLine((int)restResponse.StatusCode);
            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Status code = " + restResponse.StatusCode);
                Console.WriteLine("Response Content = " + restResponse.Content);
            }
            Get.Log(Status.Pass, "Get method is working");
            TestResult.Flush();
        }
        [Test]
        public void Deluser()
        {
            ExtentTest Del = TestResult.CreateTest("DelUser");
            var restClient = new RestClient("https://reqres.in/api");
            var restRequest = new RestRequest("users/2", Method.DELETE);
            IRestResponse restResponse = restClient.Delete(restRequest);
            Console.WriteLine(restResponse.StatusCode);
            Console.WriteLine((int)restResponse.StatusCode);
            Console.WriteLine(restResponse.ContentEncoding);
            Assert.AreEqual(204, (int)restResponse.StatusCode);
            Assert.IsTrue(restResponse.StatusCode == HttpStatusCode.NoContent);
            Assert.That(restResponse.Content.ToString(), Is.EqualTo(""));
            Del.Log(Status.Pass, "Del user is working");
            TestResult.Flush();
        }

    }
}