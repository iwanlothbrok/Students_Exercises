using System;
using System.Diagnostics;
using TaskBoard.Tests.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskBoard.WebApp.SeleniumTests
{
    public abstract class SeleniumTestsBase
    {
        protected TestDb testDb;
        protected IWebDriver driver;
        protected TestTaskBoardApp<Startup> testTaskBoardApp;
        protected string baseUrl;
        protected string username = "user" + DateTime.Now.Ticks.ToString().Substring(10);
        protected string password = "pass" + DateTime.Now.Ticks.ToString().Substring(10);

        [OneTimeSetUp]
        public void OneTimeSetupBase()
        {
            // Run the Web app in a local Web server
            this.testDb = new TestDb();
            this.testTaskBoardApp = new TestTaskBoardApp<Startup>(
                this.testDb, "../../../../TaskBoard.WebApp");
            this.baseUrl = this.testTaskBoardApp.ServerUri;

            // Setup the ChromeDriver
            var chromeOptions = new ChromeOptions();
            if (!Debugger.IsAttached)
                chromeOptions.AddArguments("headless");
            chromeOptions.AddArguments("--start-maximized");
            this.driver = new ChromeDriver(chromeOptions);

            // Set an implicit wait for the UI interaction
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public void OneTimeTearDownBase()
        {
            // Stop and dispose the Selenium driver
            this.driver.Quit();

            // Stop and dispose the local Web server
            this.testTaskBoardApp.Dispose();
        }
    }
}
