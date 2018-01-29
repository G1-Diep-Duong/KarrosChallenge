using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karros.Common;
using Karros.PageObjects;
using Karros.DataObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Karros.TestCases
{
    [TestClass]
    public class Karros : Testbase
    {

        [TestMethod]
        public void TC01FF()
        {
            Console.WriteLine("TC01 - Firefox - Verify that the data displayed on the Events page is the same data of the row that the button was clicked");
            webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();

            MainPage mainpage = new MainPage(webDriver);
            Record Record3rd = new Record();

            Console.WriteLine("Step 1: Open the website");
            mainpage.Open();
            webDriver.SwitchTo().Frame(0);

            Console.WriteLine("Step 2: Search the device id 164800178 and click on the “Events” button on the 3rd row of the result");
            Record3rd = mainpage.SearchDeviceByID("164800178").GetRecordByIndex(3);
            mainpage.ClickEventButton(3);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1].ToString());
            EventsPage eventspage = new EventsPage(webDriver);
            string ActualResult = eventspage.LblRecoverData.Text;
            string ExpectedResult = "deviceid: " + Record3rd.DeviceID + "; obdvin: " + Record3rd.Vin + "; insertiontime: " + Record3rd.Insertiontime + "; odometer: " + Record3rd.Odometer + ";";

            Console.WriteLine("Verify point:: Check the data displayed on the Events page is the same data of the row that the button was clicked");
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        //[TestMethod]
        public void TC01Chrome()
        {
            Console.WriteLine("TC01 - Chrome - Verify that the data displayed on the Events page is the same data of the row that the button was clicked");
            webDriver = new ChromeDriver(@"D:\chromedriver_win32");
            webDriver.Manage().Window.Maximize();

            MainPage mainpage = new MainPage(webDriver);
            Record Record3rd = new Record();
            mainpage.Open();
            webDriver.SwitchTo().Frame(0);
            Record3rd = mainpage.SearchDeviceByID("164800178").GetRecordByIndex(3);
            mainpage.ClickEventButton(3);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1].ToString());
            EventsPage eventspage = new EventsPage(webDriver);
            string ActualResult = eventspage.LblRecoverData.Text;
            string ExpectedResult = "deviceid: " + Record3rd.DeviceID + "; obdvin: " + Record3rd.Vin + "; insertiontime: " + Record3rd.Insertiontime + "; odometer: " + Record3rd.Odometer + ";";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }


    }
}
