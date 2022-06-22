using first_attempt.Pages;
using first_attempt.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//See https://aka.ms/new-console-template for more information

[TestFixture]
[Parallelizable]
public class TM_Test : CommonDriver
{
    //object initializing 
    HomePage homePageObject = new HomePage();
    TMPage TMPageObject = new TMPage();


    [Test, Order(1), Description("Create time and material record with valid data")]
    public void CreateTMRecord()
    {
        //Home page object initialization and definition
        homePageObject.goToTMPage(driver);

        //TM page object initialization and definition
        TMPageObject.CreateTMRecord(driver);
    }

    [Test, Order(2), Description("Edit time and material record created in test number 1")]
    public void EditTMRecord()
    {
        //Home page object initialization and definition
        homePageObject.goToTMPage(driver);
        //TM page object initialization and definition
        TMPageObject.editTMRecord(driver);
    }

    [Test, Order(3), Description("Delete time and material record edited in test number 2")]
    public void DeleteTMRecord()
    {
        //Home page object initialization and definition
        homePageObject.goToTMPage(driver);
        //TM page object initialization and definition
        TMPageObject.deleteTMRecord(driver);
    }

}

