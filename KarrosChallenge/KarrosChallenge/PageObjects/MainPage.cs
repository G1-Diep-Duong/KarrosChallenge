using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Karros.Common;
using Karros.TestCases;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Karros.PageObjects
{
    class MainPage : GeneralPage
    {
        private IWebDriver driver;

        internal MainPage Open()
        {
            throw new NotImplementedException();
        }


        #region Locators




        #endregion

        #region Elements



        #endregion

        #region Methods
        public MainPage(IWebDriver webDriver)
          : base(webDriver)
        {
            this.driver = webDriver;
        }

        #endregion

    }
}
