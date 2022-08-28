using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MeatInjectorC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver MeatObject = new ChromeDriver();
            MeatObject.Navigate().GoToUrl("https://tinder.com/");

            FunctionsNMethods helperMethod = new FunctionsNMethods();
            helperMethod.LoginFunction(MeatObject);
        }
        
    }
}
