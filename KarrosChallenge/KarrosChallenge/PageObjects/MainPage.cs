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
        static readonly By _txtSearchDevice = By.XPath("//input[@class='select2-search__field']");
        static readonly By _btnSearchDevice = By.XPath("//button[@title='Search Device']");
        static readonly By _spantest = By.XPath("//span[@class='glyphicon glyphicon-folder-close']");

        #endregion

        #region Elements

        public IWebElement Spantest
        {
            get { return FindElement(_spantest, Constant.DefaultTimeout); }
        }

        public IWebElement CboSearchDevice
        {
            get { return FindElement(_cboSearchDevice, Constant.DefaultTimeout); }
        }
        public IWebElement TxtSearchDevice
        {
            get { return FindElement(_txtSearchDevice, Constant.DefaultTimeout); }
        }
        public IWebElement BtnSearchDevice
        {
            get { return FindElement(_btnSearchDevice, Constant.DefaultTimeout); }
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

        public MainPage SearchDeviceByID(string deviceid)
        {
            //SelectElement CboRepository = new SelectElement(this.CboSearchDevice);
            //CboRepository.SelectByText(deviceid);

            //CboSearchDevice.Click();
            //TxtSearchDevice.SendKeys(deviceid);

            //IWebElement objecElement = webDriver.FindElement(By.XPath("//html//body//iframe"));
            this.webDriver.SwitchTo().Frame(1);
            BtnSearchDevice.Click();
            return this;
        }




        #endregion



    }
}
