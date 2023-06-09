﻿using AutomationFramework.Pages;
using SeleniumExtras.PageObjects;
using System;

namespace AutomationFramework.Utils
{
    /// <summary>
    /// Klasa koja inicijalicuje potrebnu stranicu
    /// </summary>
    public class AllPages
    {
        public AllPages(Browsers browser)
        {
            _browser = browser;
        }
        Browsers _browser { get; }
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.GetDriver);
            PageFactory.InitElements(_browser.GetDriver, page);
            return page;
        }
        public RegisterUserPage RegisterUserPage => GetPages<RegisterUserPage>();
        public HomePage HomePage => GetPages<HomePage>();
        public ContactPage ContactPage => GetPages<ContactPage>();
        public CustomerLookupPage CustomerLookupPage => GetPages<CustomerLookupPage>();
        public OverviewPage OverviewPage => GetPages<OverviewPage>();
        public OpenAccountPage OpenAccountPage => GetPages<OpenAccountPage>();
        public ActivityPage ActivityPage => GetPages<ActivityPage>();
        public FindTransactionPage FindTransactionPage => GetPages<FindTransactionPage>(); 
        public BillPayPage BillPayPage => GetPages<BillPayPage>();
        public TransferPage TransferPage => GetPages<TransferPage>();
        public UpdateProfilePage UpdateProfilePage => GetPages<UpdateProfilePage>();
    }
}
