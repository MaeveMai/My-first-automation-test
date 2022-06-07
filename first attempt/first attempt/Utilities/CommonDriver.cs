using first_attempt.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_attempt.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        LoginPage loginPageObject = new LoginPage();

        [OneTimeSetUp]
        public void loginAction()
        {
            //open ChromBrowser

            driver = new ChromeDriver();

            //login page object initializing and action
            loginPageObject.LoginAction(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Close();

        }
    }
}

