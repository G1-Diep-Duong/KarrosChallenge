using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karros.Common;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium.Remote;

namespace Karros.TestCases
{
   
    [TestClass]
    public class Testbase
    {
        public IWebDriver webDriver;

        DirectoryInfo di = Directory.CreateDirectory(Constant.DefaultLogFolder);
        Stopwatch stopWatch = new Stopwatch();
        FileStream ostrm;
        StreamWriter writer;
        TextWriter oldOut = Console.Out;
        string filename = "Karros-" + CommonMethods.ConvertDateTimeToString(DateTime.Now) + ".log";

      
        [TestInitialize]
        public void TestInitializeMethod()
        {
            try
            {
                ostrm = new FileStream(Constant.DefaultLogFolder + "\\" + filename, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("- Cannot open " + Constant.DefaultLogFolder + " for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

            Console.WriteLine("- Run Test Initialize");
            stopWatch.Start();
            
            webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();
        }
            
        [TestCleanup]
        public void TestCleanupMethod()
        {
            Console.WriteLine("- Run Test Cleanup");
            // CLose browser
            webDriver.Quit();
            Console.WriteLine("TC finishes in {0} seconds", stopWatch.ElapsedMilliseconds / 1000);
            stopWatch.Stop();

            //Write log area
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("- Please see the log file in " + Constant.DefaultLogFolder + "\\" + filename);
        }
    }
}
