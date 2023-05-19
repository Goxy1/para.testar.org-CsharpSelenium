using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class FindTransactionPage:BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public FindTransactionPage() {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public FindTransactionPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By accountDropDown = By.Id("accountId");
        By dateInputField = By.Id("criteria.onDate");
        By findTransactionButton = By.XPath("(//button[@class='button'][contains(@ng-click, 'DATE')])[1]");
        By transactionTable = By.Id("transactionTable");

        /// <summary>
        /// Metoda koja bira account u dropdown-u
        /// </summary>
        /// <param name="account"></param>
        private void SelectAccount(string account)
        {
            SelectElement select = new SelectElement(driver.FindElement(accountDropDown));
            select.SelectByValue(account);
        }
        /// <summary>
        /// Metoda koja upisuje vrednost u polje Find By Date
        /// </summary>
        /// <param name="date"></param>
        private void EnterFindByDate(string date)
        {
            WriteText(dateInputField,date);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Find transaction - By DATE 
        /// </summary>
        private void ClickOnFindTransaction()
        {
            ClickElement(findTransactionButton);
        }

        public bool IsTransactionResultsDisplayed()
        {
            return CommonMethods.IsElementPresented(driver, transactionTable);
        }

        /// <summary>
        /// Metoda koja vrsi pretragu racuna po datumu
        /// </summary>
        /// <param name="account"></param>
        /// <param name="date"></param>
        public void FindTransaction(string account, string date)
        {
            SelectAccount(account);
            EnterFindByDate(date);
            ClickOnFindTransaction();
            Thread.Sleep(1000);

        }
    }
}
