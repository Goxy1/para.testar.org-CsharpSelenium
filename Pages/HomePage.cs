using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class HomePage:BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public HomePage() 
        {
            driver = null;
        }
        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver"></param>
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By registerLink = By.XPath("//a[contains(., 'Register')]");

        /// <summary>
        /// 
        /// </summary>
        public void ClickOnRegisterLink()
        {
            ClickOnElement(registerLink);
        }
    }
}
