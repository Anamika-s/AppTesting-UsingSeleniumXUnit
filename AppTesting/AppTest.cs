using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AppTesting
{
    public class AppTest
    {
        IWebDriver driver;
        public AppTest() {
            // open browser
            driver = new ChromeDriver(@"C:\Users\anami\Downloads\chromedriver-win64\chromedriver-win64");
            // navigate to site
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }
        [Fact]
        public void Test1()
        {
            // Login
            IWebElement lnkLogin = driver.FindElement(By.LinkText("Login"));
           Thread.Sleep(1000);
            lnkLogin.Click();
            // UserName
            var txtUserName = driver.FindElement(By.Name("UserName"));
            Assert.True(txtUserName.Displayed);
            txtUserName.SendKeys("admin");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Password")).SendKeys("password");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            var lnkEmployeeDetails = driver.FindElement(By.LinkText("Employee Details"));
            Assert.True(lnkEmployeeDetails.Displayed);


        }
    }
}