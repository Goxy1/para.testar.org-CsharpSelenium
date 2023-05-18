﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class OverviewPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public OverviewPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public OverviewPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By openNewAccLink = By.LinkText("Open New Account");

        /// <summary>
        /// Metoda koja klikne na open new account link
        /// </summary>
        public void OpenNewAccountLink()
        {
            ClickElement(openNewAccLink);
        }

    }
}
