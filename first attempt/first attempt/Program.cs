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
Thread.Sleep(1500);

//check whether login successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")

    Console.WriteLine("login successfully, test passed");

else
    Console.WriteLine("login failed, test failed");
//identify administration and click
IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
Administration.Click();

//identify time&materials and click
IWebElement TimeAndMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeAndMaterials.Click();
Thread.Sleep(1500);

//identify create button and click
IWebElement CreateButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
CreateButton.Click();

//identify TM dropdown box and select Time
IWebElement TMDropdownBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
TMDropdownBox.Click();

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
inputPriceTextBox.SendKeys("20");

//identify save button and click
IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
SaveButton.Click();
Thread.Sleep(1500);


//check whether create successfully
IWebElement LastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
LastPageButton.Click();

IWebElement AutoTest321 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (AutoTest321.Text == "AutoTest321")
{
    Console.WriteLine("Create succeed, test pass");
}
else
{
    Console.WriteLine("Create failed, test failed");
}