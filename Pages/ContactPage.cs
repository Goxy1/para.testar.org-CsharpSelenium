﻿using AutomationFramework.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class ContactPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez paramtra
        /// </summary>
        public ContactPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">driver</param>
        public ContactPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By nameField = By.Id("name");
        By emailField = By.Id("email");
        By phoneField = By.Id("phone");
        By messageField = By.Id("message");
        By sendMessageButton = By.XPath("//input[contains(@value, 'Send to Customer Care')]");
        By successMessage = By.XPath("//div[@id='rightPanel']/p[2]");

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Name
        /// </summary>
        /// <param name="name">name</param>
        private void EnterName(string name)
        {
            WriteText(nameField, name);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje email
        /// </summary>
        /// <param name="email">email</param>
        private void EnterEmail(string email)
        {
            WriteText(emailField, email);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje phone
        /// </summary>
        /// <param name="phone">phone</param>
        private void EnterPhone(string phone)
        {
            WriteText(phoneField, phone);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje message
        /// </summary>
        /// <param name="message">message</param>
        private void EnterMessage(string message)
        {
            // Setovanje maxLength atributa na 1000
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('message').setAttribute('maxlength', '1000')");
            // Upis poruke
            WriteText(messageField, message);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Send message
        /// </summary>
        private void ClickOnSendMessage()
        {
            ClickElement(sendMessageButton);
        }

        /// <summary>
        /// Metoda koja vraca poruku iz elementa
        /// </summary>
        /// <returns>tekst poruke</returns>
        public string GetSuccessMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, successMessage);
        }

        /// <summary>
        /// Metoda koja popunjava formu contact us
        /// </summary>
        public void ContactUs(string name, string email, string phone, string message)
        {
            EnterName(name);
            EnterEmail(email);
            EnterPhone(phone);
            EnterMessage(message);
            ClickOnSendMessage();
        }
    }
}
