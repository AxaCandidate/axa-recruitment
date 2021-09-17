using Avanssur.Automation.GuiTests.PageObjects;
using Avanssur.Automation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.IO;
using System.Reflection;

namespace Avanssur.Automation.GuiTests.Tests
{
    public class BaseTest
    {
        private Properties.Settings _settings;

        private Properties.Settings Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = new Properties.Settings();
                }
                return _settings;
            }
        }

        protected string BaseUrlGui => Settings.BaseUrlGui;

        protected Serilog.Core.Logger Log => Logger.Instance;

        protected IWebDriver Driver;

        protected PagesManager Pages { get; set; }

        [SetUp]
        protected void RunBeforeEachTest()
        {
            var currentTestMethodName = TestContext.CurrentContext.Test.MethodName;
            Log.Information($"GUI Test started: {currentTestMethodName}");

            var browser = Settings.Browser;
            Log.Information($"Browser: {browser}");

            if (browser == "Chrome")
            {
                Driver = new ChromeDriver();
            }
            else if (browser == "Edge")
            {
                var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                Driver = new EdgeDriver($@"{outputDirectory}\Drivers");
            }
            else
            {
                throw new Exception("Browser not supported");
            }

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl(BaseUrlGui);
            Log.Information($"Navigated to url {BaseUrlGui}");

            Pages = new PagesManager(Driver, Log);
        }

        [TearDown]
        protected void RunAfterEachTest()
        {
            Driver.Quit();

            var currentTestMethodName = TestContext.CurrentContext.Test.MethodName;
            var currentTestResult = TestContext.CurrentContext.Result.Outcome;
            var currentTestMessage = TestContext.CurrentContext.Result.Message;
            Log.Information($"GUI Test finished: {currentTestMethodName}. Result: {currentTestResult}. Message: {currentTestMessage ?? "---"}\n");
        }
    }
}
