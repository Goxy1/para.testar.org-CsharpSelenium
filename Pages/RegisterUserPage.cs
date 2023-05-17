using AutomationFramework.Utils;
using OpenQA.Selenium;
namespace AutomationFramework.Pages
{
    public class RegisterUserPage:BasePage
    {
        
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public RegisterUserPage() 
        {
            driver = null;
        }
       
        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver"></param>
        public RegisterUserPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locator
        By firstNameField = By.Id("customer.firstName");
        By lastNameField = By.Id("customer.lastName");
        By adressField = By.Id("customer.address.street");
        By cityField = By.Id("customer.address.city");
        By stateField = By.Id("customer.address.state");
        By zipCodeField = By.Id("customer.address.zipCode");
        By phoneField = By.Id("customer.phoneNumber");
        By ssnField = By.Id("customer.ssn");
        By usernameField = By.Id("customer.username");
        By passwordField = By.Id("customer.password");
        By confirmPasswordField = By.Id("repeatedPassword");
        By registerDugme = By.XPath("//input[@value ='Register']");
        By usernameTitle = By.XPath("//div[@id='rightPanel']/h1");
       
        private void EnterFirstName(string firstName)
        {
            WriteTextToElement(firstNameField, firstName);
        }
        private void EnterLastName(string lastName)
        {
            WriteTextToElement(lastNameField, lastName);
        }
        private void EnterAdress(string adress)
        {
            WriteTextToElement(adressField, adress);
        }
        private void EnterCity(string city)
        {
            WriteTextToElement(cityField, city);
        }
        private void EnterState(string state)
        {
            WriteTextToElement(stateField, state);
        }
        private void EnterZipCode(string zipCode)
        {
            WriteTextToElement(zipCodeField, zipCode);
        }
        private void EnterPhone(string phone)
        {
            WriteTextToElement(phoneField, phone);
        }
        private void EnterSsn(string ssn)
        {
            WriteTextToElement(ssnField, ssn);
        }
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
            WriteTextToElement(confirmPasswordField, password);
        }
        private void ClickOnRegisterButton()
        {
            ClickOnElement(registerDugme);
        }
        /// <summary>
        /// Metoda koja vraca ime usera
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return CommonMethods.ReadTextFromElement(driver, usernameTitle);
        }

        public void RegisterUser(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string ssn,string username,string password)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAdress(address);
            EnterCity(city);
            EnterState(state);
            EnterZipCode(zipCode);
            EnterPhone(phone);
            EnterSsn(ssn);
            EnterUsername(username);
            EnterPassword(password);
        }
    }
}
