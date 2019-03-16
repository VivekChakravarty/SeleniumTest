using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            string homeURL = string.Empty;


            homeURL = "https://www.google.com/";

            ChromeDriver objChromDriver = new ChromeDriver();
            objChromDriver.Navigate().GoToUrl(homeURL);

            WebDriverWait wait = new WebDriverWait(objChromDriver, System.TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.CssSelector(".gLFyf.gsfi")));
            IWebElement searchText = objChromDriver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            searchText.SendKeys("Netwoven");


            WebDriverWait wait1 = new WebDriverWait(objChromDriver, System.TimeSpan.FromSeconds(15));
            wait1.Until(driver => driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]")));
            IWebElement btnClick = objChromDriver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]"));
            btnClick.Submit();
        }
    }
}