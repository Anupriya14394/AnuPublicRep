using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripProject
{
    public class BaseClass
    {
       public static IWebDriver driver;

    public static void BrowserInitialization()
        {
            driver = new ChromeDriver();

        }

        public static void OpenURL()
        {
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();

        }

        public static void EnterCities()
        {
            IWebElement fromCity = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div/div[2]/div[1]/div[2]/label/span"));
            IWebElement toCity = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div/div[2]/div[1]/div[2]/label/span"));
            
            IWebElement fromCityTextBox = driver.FindElement(By.XPath("//div/div[2]/div/div/div[2]/div[1]/div[1]/div[1]/div/div/div/input"));

            IWebElement toCityTextBox = driver.FindElement(By.XPath("//div/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/div/div/div/input"));

            fromCity.Click();
            fromCityTextBox.SendKeys("Mumbai, India");
            toCity.Click();
            toCityTextBox.SendKeys("Chennai, India");
            
        }


        public static void CloseBrowser()
        {
            driver.Close();

            driver.Quit();

        }

    }
}
