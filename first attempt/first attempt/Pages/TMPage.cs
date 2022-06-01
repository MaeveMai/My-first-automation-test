using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_attempt.Pages
{
    public class TMPage
    {
        public void CreateTMRecord(IWebDriver driver)
        {
            //identify create button and click
            IWebElement CreateButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateButton.Click();

            //identify TM dropdown box and select Time
            IWebElement TMDropdownBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            TMDropdownBox.Click();
            Thread.Sleep(1500);

            IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            TimeOption.Click();

            //identify code textbox and input code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("AutoTest321");

            //identify description textbox and input description
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("654352");

            //identify unit price textbox and input price
            IWebElement inputPriceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            inputPriceTextBox.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20");

            //identify save button and click
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveButton.Click();
            Thread.Sleep(1500);

            //check whether create successfully
            IWebElement LastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPageButton.Click();

            IWebElement AutoTest321 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(AutoTest321.Text == "AutoTest321", "Create failed, test failed");
            Thread.Sleep(1000);
        }

        public void editTMRecord(IWebDriver driver)
        {
            //Identify edit button and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //iddentify typecode dropdownbox and change option
            IWebElement EditTMDropdownBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            EditTMDropdownBox.Click();
            Thread.Sleep(1000);

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();

            //identify code textbox and change code name
            IWebElement EditCodeTextbox = driver.FindElement(By.Id("Code"));
            EditCodeTextbox.Clear();
            EditCodeTextbox.SendKeys("TEFA123");

            //identify description textbox and change description
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("C123123");

            //identify price textbox and change price
            IWebElement EditinputPriceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            EditinputPriceTextBox.Click();

            IWebElement EditpriceTextbox = driver.FindElement(By.Id("Price"));
            EditpriceTextbox.Clear();
            //Thread.Sleep(1000);

            EditinputPriceTextBox.Click();
            EditpriceTextbox.SendKeys("100");

            //identify save button and click
            IWebElement EditSaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            EditSaveButton.Click();
            Thread.Sleep(1500);

            //check whether edit successfully

            IWebElement CodeShowed = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement typeShowed = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement DescShowed = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement priceShowed = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            Assert.That(CodeShowed.Text == "TEFA123"
            && typeShowed.Text == "M"
            && DescShowed.Text == "C123123"
            && priceShowed.Text == "$100.00"
             ,"Edit Failed, test failed");
        }
        public void deleteTMRecord(IWebDriver driver)
        {
            //identify delete button and click
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //identify confirm button and click
            IAlert ComfirmationMessage = driver.SwitchTo().Alert();
            ComfirmationMessage.Accept();

            //Refresh the page
            driver.Navigate().Refresh();
            Thread.Sleep(2000);

            //check whether delete successfully
            IWebElement CodeShowed2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(CodeShowed2.Text != "TEFA123", "Delete Failed, test failed");

        }
    }
}
