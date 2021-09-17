using OpenQA.Selenium;
using Serilog.Core;
using System;
using System.Threading;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class Element<T>
    {
        protected IWebDriver Driver;

        protected By Locator { get; set; }

        protected T PageObject { get; set; }

        protected Logger Log { get; set; }

        public Element(T pageObject, By by, IWebDriver driver, Logger logger)
        {
            PageObject = pageObject;
            Driver = driver;
            Locator = by;
            Log = logger;
        }

        public IWebElement WaitForElementToBeVisible(float timeout = 20)
        {
            Log.Information($"Waiting for element to be visible. Locator: {Locator}");

            IWebElement element = null;

            bool isElementVisible = 
                SpinWait.SpinUntil(() =>
                {
                    try
                    {
                        element = Driver.FindElement(Locator);
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }

                    return element.Displayed;
                },
                TimeSpan.FromSeconds(timeout));

            if (isElementVisible)
            {
                Log.Information("Element located as visible");
            }
            else
            {
                Log.Warning("Element not located as visible");
            }

            return element;
        }
    }
}
