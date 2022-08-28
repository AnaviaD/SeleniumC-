using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MeatInjectorC
{
    internal class FunctionsNMethods
    {
        public void LoginFunction(IWebDriver MeatObject)
        {
            var loginTB = MeatObject.FindElement(By.XPath("//*[@id=\"q243527110\"]/div/div[1]/div/main/div[1]/div/div/div/div/header/div/div[2]/div[2]/a"));
            loginTB.Click();
        }
    }
}
