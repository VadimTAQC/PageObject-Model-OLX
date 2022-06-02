using OpenQA.Selenium;
using System;


namespace PageObjectOLX
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement txtEmail => driver.FindElement(By.XPath(" (//input[@id='userEmail'])[1]"));
        public void SendTextToEmail(string text) => txtEmail.SendKeys(text);
        private IWebElement txtPassword => driver.FindElement(By.XPath("(//input[@id ='userPass'])[1]"));
        public void SendTextToPassword(string text) => txtPassword.SendKeys(text);

        private IWebElement btnLogin => driver.FindElement(By.XPath("(//button[@class ='login-button login-button--submit'])[1]"));
        public void ButtonClick() => btnLogin.Click();
    }
}
