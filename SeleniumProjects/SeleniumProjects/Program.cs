using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver chrDriv = new ChromeDriver();
            chrDriv.Navigate().GoToUrl("https://www.google.com.mx/?hl=es-419");

            var inputSearch = chrDriv.FindElement(By.Name("q"));
            inputSearch.SendKeys("Test text");
        }
    }
}
