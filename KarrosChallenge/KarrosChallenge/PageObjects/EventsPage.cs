using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Karros.Common;
using Karros.DataObjects;
using Karros.TestCases;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Karros.PageObjects
{
    class EventsPage : GeneralPage
    {
        private IWebDriver driver;

        #region Locators

        static readonly By _lblRecoverData = By.XPath("//label[@id='recover_data']");

        #endregion

        #region Elements
        public IWebElement LblRecoverData
        {
            get { return FindElement(_lblRecoverData, Constant.DefaultTimeout); }
        }
        #endregion

        #region Methods

        public EventsPage(IWebDriver webDriver)
          : base(webDriver)
        {
            this.driver = webDriver;
        }

        public string GetRecoverDataRow ()
        {            
            return LblRecoverData.Text;          
            
        }


        #endregion

    }
}
