using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.FedCm;
using System.Security.Cryptography;
//using OpenQA.Selenium.Chrome.ChromeDriver;


namespace Frontend_Regression
{
    public class Tests
    {

        public void Setup()
        {
            //  
        }

        [Test]
        public void Test_userCanAccessAboutPage ()
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://mansaalexgriffiths.wixsite.com/alexthescribe/");
            driver.Manage().Window.Maximize();
            // find about Page 
            var button = driver.FindElement(By.Id("comp-iszt89yr0label"));
            button.Click();
            Assert.That(driver.Url.Equals("https://mansaalexgriffiths.wixsite.com/alexthescribe/about"));
            driver.Quit();
        }
        
        [Test]
        public void Test_userCanAccessSubjectPages()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mansaalexgriffiths.wixsite.com/alexthescribe/");
            driver.Manage().Window.Maximize();
            driver.Quit();  
        }

        [Test]
        public void Test_userCanAccessBlog()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://mansaalexgriffiths.wixsite.com/alexthescribe/blog");
            driver.Manage().Window.Maximize();
            Console.WriteLine("run executed");
            driver.Quit();

            //verify title is shown? 
        }



    }
}    