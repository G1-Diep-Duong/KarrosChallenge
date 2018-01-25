﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karros.Common;
using Karros.PageObjects;
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
            mainpage.Open();
            //mainpage.SearchDeviceByID("164800178");
            
            mainpage.Spantest.Click();

            webDriver.SwitchTo().Frame(0);
            //.FindElement(By.XPath("//button[@title='Search Device']")).Click();

            mainpage.BtnSearchDevice.Click();


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
