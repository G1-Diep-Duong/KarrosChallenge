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
    class MainPage : GeneralPage
    {
        private IWebDriver driver;

        #region Locators

        static readonly By _cboSearchDevice = By.XPath("//span[@id='select2-device_id-container']");
        static readonly By _txtSearchDevice = By.XPath("//input[@class='select2-search__field']");
        static readonly By _btnSearchDevice = By.XPath("//button[@title='Search Device']");
        static readonly By _btnComplexSearch = By.XPath("//td[@id='search_jqGrid_top']//span");

        //td[@id='search_jqGrid_top']//span

        #endregion

        #region Elements

        public IWebElement BtnComplexSearch
        {
            get { return FindElement(_btnComplexSearch, Constant.DefaultTimeout); }
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
            CboSearchDevice.Click();
            TxtSearchDevice.Set(deviceid);
            TxtSearchDevice.SendKeys(Keys.Enter);
            BtnSearchDevice.Click();
            return this;
        }

        public EventsPage ClickEventButton(int index)
        {
            EventsPage eventspage = new EventsPage(this.webDriver);
            string DynamicXPath = "//table[@id='jqGrid']//tr["+ (index+1) +"]//input[@value='Events']";
            this.FindElement(By.XPath(DynamicXPath)).Click();
            return eventspage;
        }

        public Record GetRecordByIndex(int index)
        {
            Record record = new Record();
            string Device = "//table[@id='jqGrid']//tr[" + (index + 1) + "]//td[@aria-describedby='jqGrid_deviceid']";
            string Vin = "//table[@id='jqGrid']//tr[" + (index + 1) + "]//td[@aria-describedby='jqGrid_obdvin']";
            string Odometer = "//table[@id='jqGrid']//tr[" + (index + 1) + "]//td[@aria-describedby='jqGrid_obdtrueodometer']";
            string Insertiontime = "//table[@id='jqGrid']//tr[" + (index + 1) + "]//td[@aria-describedby='jqGrid_insertiontime']";

            record.DeviceID = this.FindElement(By.XPath(Device)).Text;
            record.Vin = this.FindElement(By.XPath(Vin)).Text.Replace("'"," ").Trim();
            record.Odometer = this.FindElement(By.XPath(Odometer)).Text;
            record.Insertiontime = this.FindElement(By.XPath(Insertiontime)).Text;

            return record;
        }
        #endregion



    }
}
