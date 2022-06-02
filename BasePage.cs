using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectOLX
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebElement btnMessages => driver.FindElement(By.XPath("//a[@class='tdnone inlblk']"));
        private IWebElement btnFavourites => driver.FindElement(By.XPath("//*[@class='tdnone inlblk hidden']"));
        private IWebElement btnProfile => driver.FindElement(By.XPath("//*[@class='userbox-login tdnone']"));
        private IWebElement btnDeclaration => driver.FindElement(By.XPath("//*[@class='postnewlink fbold tdnone']"));
        private IWebElement btnWallet => driver.FindElement(By.XPath("//a[@href='https://www.olx.ua/payment/wallet/topupaccount/']"));
        private IWebElement btnBuyParcel => driver.FindElement(By.XPath("//a[@href='https://www.olx.ua/buypackage/']"));
        private IWebElement txtHeader1 => driver.FindElement(By.XPath("//a[@class='tdnone inlblk']"));
        private IWebElement txtHeader2 => driver.FindElement(By.XPath("//*[@class='tdnone inlblk hidden']"));
        private IWebElement txtHeader3 => driver.FindElement(By.XPath("//*[@class='userbox-login tdnone']"));
        private IWebElement txtHeader4 => driver.FindElement(By.XPath("//*[@class='postnewlink fbold tdnone']"));
        private IWebElement txtHeader5 => driver.FindElement(By.XPath("//a[@href='https://www.olx.ua/payment/wallet/topupaccount/']"));
        private IWebElement txtHeader6 => driver.FindElement(By.XPath("//a[@href='https://www.olx.ua/buypackage/']"));

        public string GetTextFromHeader1() => txtHeader1.Text;
        public string GetTextFromHeader2() => txtHeader2.Text;
        public string GetTextFromHeader3() => txtHeader3.Text;
        public string GetTextFromHeader4() => txtHeader4.Text;
        public string GetTextFromHeader5() => txtHeader5.Text;
        public string GetTextFromHeader6() => txtHeader6.Text;
        public void ClickMessages() => btnMessages.Click();
        public void ClickFavourites() => btnFavourites.Click();
        public void ClickProfile() => btnProfile.Click();
        public void ClickDeclaration() => btnDeclaration.Click();
        public void ClickWallet() => btnWallet.Click();
        public void ClickParcel() => btnBuyParcel.Click();


    }
}
