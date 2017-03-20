using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace TestingSomeWebside
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object from google chrome
            IWebDriver driver = new ChromeDriver();

            //going throught the amazon web page
            Utilities.GotoUrl(driver,"https://www.amazon.com");
            
            //login
            Utilities.Click(driver, "nav-link-accountList", "Id");
            Utilities.EnterText(driver, "email", "ericksondelacruz@hotmail.com", "Name");
            Utilities.EnterText(driver, "password", "delacruz17", "Name");
            Utilities.Click(driver, "signInSubmit", "Id");

            //searching the article to buy
            Utilities.EnterText(driver, "field-keywords", "samgung  galaxy tab 3", "Name");
            Utilities.Click(driver, "nav-input", "Class");

            //selecting the article
            var res= Utilities.GetElementss(driver, "cfMarker", "Class", 2);
            res.Click();

            //adding to cart and going to the shiping info
            Utilities.Click(driver, "add-to-cart-button-ubb", "Id");
            Utilities.Click(driver, "hlb-ptc-btn-native", "Id");

            //filling out the form for the shipping
            Utilities.EnterText(driver, "enterAddressFullName", "Erison De La Cruz", "Name");
            Utilities.EnterText(driver, "enterAddressAddressLine1", "Calle 3 #1", "Name");
            Utilities.EnterText(driver, "enterAddressCity", "Santiago", "Name");
            Utilities.EnterText(driver, "enterAddressStateOrRegion", "Santiago de los caballeros", "Name");
            Utilities.EnterText(driver, "enterAddressPostalCode", "51031", "Name");
            Utilities.EnterText(driver, "enterAddressPhoneNumber", "809-513-4923", "Name");
            Utilities.DropDown(driver, "enterAddressCountryCode", "Dominican Republic", "Name");
            //click continue
            Utilities.Click(driver, "shipToThisAddress", "Name");

        }
        
    }
}
