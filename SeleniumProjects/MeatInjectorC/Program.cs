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
            

            IWebDriver MeatObject = new ChromeDriver();
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
