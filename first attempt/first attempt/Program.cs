// See https://aka.ms/new-console-template for more information
//open chrom browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//find username textbox and input username
IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
UsernameTextbox.SendKeys("hari");

//find password textbox and input password
IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");
//find login button and click
IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
LoginButton.Click();

//check whether login successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")

    Console.WriteLine("login successfully, test passed");

else
    Console.WriteLine("login failed, test failed");