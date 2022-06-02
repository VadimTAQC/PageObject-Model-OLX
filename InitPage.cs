using OpenQA.Selenium;
using System;


namespace PageObjectOLX
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnLogin => driver.FindElement(By.XPath(" //*[@class='userbox-login tdnone']"));
        public void ClickLogin() => btnLogin.Click();
    }
}
