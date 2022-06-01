using first_attempt.Pages;
using first_attempt.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//See https://aka.ms/new-console-template for more information

[TestFixture]
public class TM_Test : CommonDriver
{
    [SetUp]
    public void loginAction()
    {
        //open ChromBrowser
        //IWebDriver driver = new ChromeDriver();
        driver = new ChromeDriver();

        //login page object initializing and action
        LoginPage loginPageObject = new LoginPage();
        loginPageObject.LoginAction(driver);

        //homepage object initializing and action
        HomePage homePageObject = new HomePage();
        homePageObject.goToTMPage(driver);
    }

    [Test]
    public void CreateTMRecord()
    {
        //TMpage object initializing and create new TM record
        TMPage TMPageObject = new TMPage();
        TMPageObject.CreateTMRecord(driver);
    }

    [Test]
    public void EditTMRecord()
    {
        //Edit existing TM record
        TMPage TMPageObject = new TMPage();
        TMPageObject.editTMRecord(driver);
    }

    [Test]
    public void DeleteTMRecord()
    {
        //Delete existing record
        TMPage TMPageObject = new TMPage();
        TMPageObject.deleteTMRecord(driver);
    }
    [TearDown]
    public void CloseTestRun()
    {
        driver.Close();

    }
}

