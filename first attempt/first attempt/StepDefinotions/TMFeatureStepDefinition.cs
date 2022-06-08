using first_attempt.Pages;
using first_attempt.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace first_attempt.StepDefinotions
{
    [Binding]
    public class TMFeatureStepDefinition:CommonDriver
    {
        [Given(@"I login to turnup portal successfully")]
        public void GivenILoginToTurnupPortalSuccessfully()
        {
            //open ChromBrowser
            driver = new ChromeDriver();

            //login page object initializing and action
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginAction(driver);
        }

        [When(@"I navigate to Time&Material page")]
        public void WhenINavigateToTimeMaterialPage()
        {
            //Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.goToTMPage(driver);
        }

        [When(@"I create a new time/material record")]
        public void WhenICreateANewTimeMaterialRecord()
        {
            //TM page object initialization and definition
            TMPage TMPageObject = new TMPage();
            TMPageObject.CreateTMRecord(driver);
        }

        [Then(@"A new T&M record should be create successfully")]
        public void ThenANewTMRecordShouldBeCreateSuccessfully()
        {
            //Assertion
            TMPage TMPageObject = new TMPage();
            string CodeShowed1 = TMPageObject.GetNewCode(driver);
            string typeShowed1 = TMPageObject.GetNewTypeCode(driver);
            string DescShowed1 = TMPageObject.GetNewDescription(driver);
            string priceShowed1 = TMPageObject.GetNewPrice(driver);


            Assert.That(CodeShowed1 == "AutoTest321", "Create code Failed, test failed");
            Assert.That(typeShowed1 == "T", "Create type Failed, test failed");
            Assert.That(DescShowed1 == "654352", "Create description Failed, test failed");
            Assert.That(priceShowed1 == "$20.00", "Create price Failed, test failed");
            
        }




    }
}
