
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace AutomationFramework.Utils
{
    public class CommonMethods
    {

        public static WebDriverWait wait;

        /// <summary>
        /// Metoda koja klikne na element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public static  void ClickOnElement(IWebDriver driver, By element)
        {
            driver.FindElement(element).Click();
        }
        /// <summary>
        /// Metoda koja upisuje text u element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="text"></param>
        public static void WriteTextToElement(IWebDriver driver, By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public static string GenerateRandomUsernmae()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string username = "Random user " + randomNumber;
            return username;
        }

        public static string ReadTextFromElement(IWebDriver driver, By element, uint timeSpan=20)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeSpan));
            return driver.FindElement(element).Text;
        }
        /// <summary>
        /// Metoda koja potvrdjuje alert box
        /// </summary>
        public static void AcceptAlertBox(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Metoda koja vraca vrednosti celija iz prvog reda u tabeli
        /// </summary>
        /// <returns></returns>
        public List<string> GetValuesFromFirstTableRow(IWebDriver driver)
        {
            List<string> values = new List<string>();
            ReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//tr[@class='success']"));

            try
            {
                IWebElement firstRow = rows[0];
                ReadOnlyCollection<IWebElement> cells = driver.FindElements(By.XPath("//tr[@class='success']/td"));

                foreach (IWebElement cell in cells)
                {
                    values.Add(cell.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return values;
        }
    }
}
