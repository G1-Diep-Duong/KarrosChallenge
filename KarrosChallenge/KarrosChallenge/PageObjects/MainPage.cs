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


        #region Locators

        static readonly By _cboSearchDevice = By.XPath("//span[@id='select2-device_id-container']");


        #endregion

        #region Elements

        public IWebElement CboSearchDevice
        {
            get { return FindElement(_cboSearchDevice, Constant.DefaultTimeout); }
        }

        #endregion

        #region Methods
        public MainPage(IWebDriver webDriver)
          : base(webDriver)
        {
            this.driver = webDriver;
        }



        public MainPage Open()
        {
            webDriver.Navigate().GoToUrl(Constant.HomePageURL);
            return this;
        }

        #endregion



    }
}
