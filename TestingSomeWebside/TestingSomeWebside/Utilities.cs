using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace TestingSomeWebside
{
    class Utilities
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            else if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);

            }

        }
        
        public static IWebElement GetElement(IWebDriver driver, string element, string elementType) {

            IWebElement Got = null;

            if (elementType == "Class")
            {
                Got = driver.FindElement(By.ClassName(element));

            }
            else if (elementType == "Id") {

                Got = driver.FindElement(By.Id(element));
            }
            else if (elementType == "Name")
            {

                Got = driver.FindElement(By.ClassName(element));
            }

            return Got;
        }

        public static IWebElement GetElementss(IWebDriver driver, string element, string elementType,int pos)
        {

            IWebElement Got = null;

            if (elementType == "Class")
            {
                Got = driver.FindElements(By.ClassName(element))[pos];

            }
            else if (elementType == "Id")
            {

                Got = driver.FindElements(By.Id(element))[pos];
            }
            else if (elementType == "Name")
            {

                Got = driver.FindElements(By.ClassName(element))[pos];
            }

            return Got;
        }

        public static void GotoUrl(IWebDriver driver ,string url) {

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public static void Click(IWebDriver driver, string element, string elementType)
        {
            try
            {
                if (elementType == "Id")
                {
                    driver.FindElement(By.Id(element)).Click();
                }
                else if (elementType == "Name")
                {
                    driver.FindElement(By.Name(element)).Click();

                }
                else if (elementType == "Class")
                {
                    driver.FindElement(By.ClassName(element)).Click();

                }
                else if (elementType == "LinkText")
                {
                    driver.FindElement(By.LinkText(element)).Click();
                }

                else if (elementType == "CssSelector")
                {
                    driver.FindElement(By.CssSelector(element)).Click();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void DropDown(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            else if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

            }
        }


    }

}
