using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\SeleniumDevOps\\SeleniumTest\\SeleniumTest\\bin\\Debug\\netcoreapp2.1");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
           IWebElement query =  driver.FindElement(By.Name("q"));
            query.SendKeys("Netwoven");
            query.Submit();


        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}