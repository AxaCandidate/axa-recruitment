using OpenQA.Selenium;
using Serilog.Core;
using System;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class ElementClickable<T> : Element<T>
    {
        public ElementClickable(T pageObject, By locator, IWebDriver driver, Logger logger) : base (pageObject, locator, driver, logger)
        {
        }

        public T Click(float timeout = 20)
        {
            var element = WaitForElementToBeVisible(timeout);
            
            try
            {
                element.Click();
            }
            catch (NullReferenceException)
            {
                Log.Error($"Cannot click element. Locator: {Locator}");
                throw;
            }

            return PageObject;
        }
    }
}
