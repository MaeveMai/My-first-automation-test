using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_attempt.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            //maximize window
            driver.Manage().Window.Maximize();

            //launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                //find username textbox and input username
                IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
                UsernameTextbox.SendKeys("hari");

                //find password textbox and input password
                IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
                PasswordTextbox.SendKeys("123123");

                //find login button and click
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();
                //Thread.Sleep(1500);
            }
            catch(Exception ex)
            {
                Assert.Fail("turn up portal coudn't launch",ex.Message);
            }

            //check whether login successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(hellohari.Text == "Hello hari!", "login failed, test failed");

        }
    }
}

