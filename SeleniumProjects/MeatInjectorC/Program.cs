using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace MeatInjectorC
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            //Create a instance of ChromeOptions class
            ChromeOptions options = new ChromeOptions();

            //Add chrome switch to disable notification - "**--disable-notifications**"
            options.AddArguments("--disable-notifications");
            

            IWebDriver MeatObject = new ChromeDriver(options);
            MeatObject.Navigate().GoToUrl("https://tinder.com/");



            //Dando click al boton para hacer login
            FunctionsNMethods helperMethod = new FunctionsNMethods(MeatObject);
            helperMethod.LoginFunction(MeatObject);

            //Seleccionando la segunda ventana
            helperMethod.BtnClickLoginFunction(MeatObject);
            //var ventanas = helperMethod.WindoHandles(MeatObject);
            //Login on Face
            helperMethod.loginFaceWindow(MeatObject);


        }

    }
}
