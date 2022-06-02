using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectOLX
{
    public class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver driver) : base (driver)
        {

        }
        private IWebElement myProfile => driver.FindElement(By.XPath("//*[@class='userbox-login tdnone']"));
        public void MyProfileClick() => myProfile.Click();
        
    }
}
