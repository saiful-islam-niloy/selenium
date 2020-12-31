using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    public class ITest
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("/usr/local/bin/chromedriver_linux64");
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("170042065");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("Abc.1234");
            driver.FindElement(By.Id("loginbtn")).Click();
            String at = driver.Title;
            Console.WriteLine(at);

            String et = "E-Learning Platform | DUET, Gazipur: Log in to the site";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
