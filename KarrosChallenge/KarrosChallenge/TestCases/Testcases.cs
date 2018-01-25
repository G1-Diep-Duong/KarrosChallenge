using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karros.Common;
using Karros.PageObjects;
using Karros.DataObjects;
using OpenQA.Selenium;

namespace Karros.TestCases
{
    [TestClass]
    public class Karros : Testbase
    {

        [TestMethod]
        public void TC01()
        {
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


        //[TestMethod]
        public void zSandbox()
        {
            //string dataprofilename = "Test Module Execution Failure Trend by Build";
            //string dynamicXpath = String.Format("//table[@class='GridView']" + CommonMethods.XPathContainGenerate("td", dataprofilename) + "/following-sibling::td[count(//th[text()='Action']/preceding-sibling::th)-1]/a[text()='Delete']", dataprofilename);
            //Console.WriteLine("sSandbox test case");
            //LoginPage loginpage = new LoginPage(webDriver).Open();
            //MainPage mainpage = loginpage.Login(Constant.DefaultUsername, "", Constant.DefaultRepository);
            //mainpage.GotoDataProfilesPage().FindElement(By.XPath(dynamicXpath), 5).Blink(5);
        }
    }
}
