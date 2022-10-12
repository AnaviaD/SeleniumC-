using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MeatInjectorC
{
    internal class FunctionsNMethods
    {
        //Obteniendo un TimeSpan para darle tiempo a las acciones
        TimeSpan ts = TimeSpan.FromSeconds(3);

        IWebDriver MeatObject;
        WebDriverWait w;

        public FunctionsNMethods(IWebDriver MeatObject)
        {
            this.MeatObject = MeatObject;
        }


        public void LoginFunction(IWebDriver MeatObject)
        {
            var loginTB = MeatObject.FindElement(By.XPath("//*[@id=\"q1623655810\"]/div/div[1]/div/main/div[1]/div/div/div/div/header/div/div[2]/div[2]/a"));
            loginTB.Click();
        }

        public void BtnClickLoginFunction(IWebDriver MeatObject)
        {
            //Adding a helper thing wait of webdriver
            WebDriverWait w = new(MeatObject, TimeSpan.FromSeconds(4));
            this.w = w;

            //IWebElement btnLoginFace = MeatObject.FindElement(By.XPath("//*[@id=\"q - 1484853966\"]/main/div/div[1]/div/div/div[3]/span/div[2]/button"));

            w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-104725266\"]/main/div/div[1]/div/div/div[3]/span/div[2]/button")));
            var btnLoginTB = MeatObject.FindElement(By.XPath("//*[@id=\"q-104725266\"]/main/div/div[1]/div/div/div[3]/span/div[2]/button"));
            btnLoginTB.Click();
        }


        //Metodo para ver cuantas ventanas tenemos
        public IList<string> WindoHandles(IWebDriver MeatObject)
        {
            IList<string> totWindowHandles = new List<string>(MeatObject.WindowHandles);
            return totWindowHandles;
        }

        public void loginFaceWindow(IWebDriver MeatObject)
        {
            var base_window = MeatObject.WindowHandles[0];
            MeatObject.SwitchTo().Window(MeatObject.WindowHandles[1]);

            w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"email\"]")));
            var emailInput = MeatObject.FindElement(By.XPath("//*[@id=\"email\"]"));
            emailInput.SendKeys("drack_cuervo@outlook.com");

            w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pass\"]")));
            var passInput = MeatObject.FindElement(By.XPath("//*[@id=\"pass\"]"));
            passInput.SendKeys("herizo44");

            w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"loginbutton\"]")));
            var LoginBtnFaceB = MeatObject.FindElement(By.XPath("//*[@id=\"loginbutton\"]"));
            LoginBtnFaceB.Click();


            MeatObject.SwitchTo().Window(base_window);

            //w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div/div/div[3]/button[1]")));
            //var GlobalPosition = MeatObject.FindElement(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div/div/div[3]/button[1]"));
            //GlobalPosition.Click();

            //w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div/div/div[3]/button[1]")));
            //var notificaciones = MeatObject.FindElement(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div/div/div[3]/button[1]"));
            //notificaciones.Click();


            w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q1623655810\"]/div/div[2]/div/div/div[1]/div[1]/button")));
            var aceptarCondiciones = MeatObject.FindElement(By.XPath("//*[@id=\"q1623655810\"]/div/div[2]/div/div/div[1]/div[1]/button"));
            aceptarCondiciones.Click();

            //IAlert notificationAlert = MeatObject.SwitchTo().Alert();
            //notificationAlert.Dismiss();


            
            //*[@id="q-1484853966"]/main/div/div/div/div[3]/button[1]
        }


        public void firstLike(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q1623655810\"]/div/div[1]/div/main/div[1]/div/div/div[1]/div[1]/div/div[4]/div/div[4]/button")));
                IWebElement likeBtn = MeatObject.FindElement(By.XPath("//*[@id=\"q1623655810\"]/div/div[1]/div/main/div[1]/div/div/div[1]/div[1]/div/div[4]/div/div[4]/button"));
                likeBtn.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void likeLoop(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q1623655810\"]/div/div[1]/div/main/div[1]/div/div/div[1]/div[1]/div/div[5]/div/div[4]/button")));
                IWebElement likeBtn = MeatObject.FindElement(By.XPath("//*[@id=\"q1623655810\"]/div/div[1]/div/main/div[1]/div/div/div[1]/div[1]/div/div[5]/div/div[4]/button"));
                likeBtn.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
                superLikeNoTnxBtn(MeatObject);
                noInstalarNoseQueCosaBtn(MeatObject);
                platinumOfferBtn(MeatObject);
                likeDissmisBtn(MeatObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                superLikeNoTnxBtn(MeatObject);
                noInstalarNoseQueCosaBtn(MeatObject);
                platinumOfferBtn(MeatObject);
                likeDissmisBtn(MeatObject);
            }

        }

        public void superLikeNoTnxBtn(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q1095858032\"]/main/div/button[2]")));
                IWebElement ntxSuperLike = MeatObject.FindElement(By.XPath("//*[@id=\"q1095858032\"]/main/div/button[2]"));
                ntxSuperLike.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void noInstalarNoseQueCosaBtn(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-104725266\"]/main/div/div[2]/button[2]")));
                IWebElement noInstallIdkw = MeatObject.FindElement(By.XPath("//*[@id=\"q-104725266\"]/main/div/div[2]/button[2]"));
                noInstallIdkw.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void platinumOfferBtn(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q1095858032\"]/main/div/button[2]")));
                IWebElement platinumBtn = MeatObject.FindElement(By.XPath("//*[@id=\"q1095858032\"]/main/div/button[2]"));
                platinumBtn.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void likeDissmisBtn(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-1140356987\"]/main/div/div[1]/div/div[3]/button")));
                IWebElement likeDBtn = MeatObject.FindElement(By.XPath("//*[@id=\"q-1140356987\"]/main/div/div[1]/div/div[3]/button"));
                likeDBtn.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void boostNoTnxBtn(IWebDriver MeatObject)
        {
            try
            {
                w.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div[2]/button[3]")));
                IWebElement boostbtn = MeatObject.FindElement(By.XPath("//*[@id=\"q-1484853966\"]/main/div/div[2]/button[3]"));
                boostbtn.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}
