using first_attempt.Pages;
using first_attempt.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_attempt.perform_test
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Test:CommonDriver
    {
        //page object initializing 
        HomePage HomePageObj = new HomePage();
        EmployeePage EmployeePageObj = new EmployeePage();

        [Test,Order(1)]
        public void CreateNewEmployee()
        {
            HomePageObj.GoToEmployeePage(driver);

            EmployeePageObj.CreateEmployee(driver);

        }

        [Test, Order(2)]
        public void EditEmployee()
        {
            HomePageObj.GoToEmployeePage(driver);
            EmployeePageObj.EditEmployee(driver);
        }

        [Test,Order(3)]
        public void DeleteEmployee()
        {
            HomePageObj.GoToEmployeePage(driver);
            EmployeePageObj.DeleteEmployee(driver);
        }
    }
}
