using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_attempt.Pages
{
    public class HomePage
    {
        public void goToTMPage(IWebDriver driver)
        {
            try
            {
                //identify administration and click
                IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                Administration.Click();

                //identify time&materials and click
                IWebElement TimeAndMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                TimeAndMaterials.Click();
                //Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                Assert.Fail("can not go to T&M Page",ex.Message);
            }

        }
    }
}
