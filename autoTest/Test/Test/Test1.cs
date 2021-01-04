using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test1
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://sis.iutoic-dhaka.edu/login";
            IWebElement element = driver.FindElement(By.XPath("//*[@id='kt_login']/div/div[1]/div/div/div/div[2]/form/div[1]/input"));
            element.SendKeys("170042024");
            IWebElement password = driver.FindElement(By.XPath("//*[@id='kt_login']/div/div[1]/div/div/div/div[2]/form/div[2]/input"));
            password.SendKeys("*****");
            driver.FindElement(By.XPath("//*[@id='m_login_signin_submit']")).Click();
            driver.FindElement(By.XPath("//*[@id='kt_aside_menu']/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("//*[@id='kt_aside_menu']/ul/li[3]/a")).Click();
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
