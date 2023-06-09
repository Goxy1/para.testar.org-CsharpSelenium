﻿using AutomationFramework.Utils;
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
        /// Konstruktor sa parametrom
        /// </summary>
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By registerLink = By.XPath("//a[contains(., 'Register')]");
        By usernameField = By.Name("username");
        By passwordField = By.Name("password");
        By loginButton = By.XPath("//input[@value='Log In']");
        By accountOverview = By.ClassName("ng-scope");
        By forgotLoginInfoLink = By.XPath("//a[contains(., 'Forgot login info?')]");
        By logoutLink = By.XPath("//a[contains(., 'Log Out')]");
        By contactIcon = By.XPath("//a[contains(., 'contact')]");



        /// <summary>
        /// Metoda koja klikne na link Register
        /// </summary>
        public void ClickOnRegisterLink()
        {
            ClickElement(registerLink);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Username
        /// </summary>
        /// <param name="username">Username</param>
        public void EnterUsername(string username)
        {
            WriteText(usernameField, username);
        }

        /// <summary>
        /// Metoda koja unosi vrednost u polje Password
        /// </summary>
        /// <param name="password">Password</param>
        public void EnterPassword(string password)
        {
            WriteText(passwordField, password);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Login
        /// </summary>
        public void ClickOnLoginButton()
        {
            ClickElement(loginButton);
        }

        /// <summary>
        /// Metoda koja klikne na link Forgot login info?
        /// </summary>
        public void ClickOnForgotLoginInfo()
        {
            ClickElement(forgotLoginInfoLink);
        }

        /// <summary>
        /// Metoda koja klikne na logout link
        /// </summary>
        public void ClickOnLogout()
        {
            ClickElement(logoutLink);
        }

        /// <summary>
        /// Proverava da li je account overview element vidljiv
        /// </summary>
        /// <returns>Vraca bool vrednost u zavisnosti od vidljivosti elementa</returns>
        public bool IsAccountOverviewPresented()
        {
            return CommonMethods.IsElementPresented(driver, accountOverview);
        }

        /// <summary>
        /// Metoda koja klikne na contact ikonicu
        /// </summary>
        public void ClickOnContact()
        {
            ClickElement(contactIcon);
        }

        /// <summary>
        /// Metoda koja popunjava formu za login
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickOnLoginButton();
        }
    }
}
