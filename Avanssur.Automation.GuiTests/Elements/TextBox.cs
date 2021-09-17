using OpenQA.Selenium;
using Serilog.Core;
using System;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class TextBox<T> : ElementClickable<T>
    {
        public TextBox(T pageObject, By locator, IWebDriver driver, Logger logger) : base(pageObject, locator, driver, logger)
        {
        }

        public T EnterText(string value, float timeout = 20)
        {
            var element = WaitForElementToBeVisible();

            try
            {
                element.SendKeys(value);
            }
            catch (Exception)
            {
                Log.Error($"Cannot enter text to element. Text: {value}, Locator: {Locator}");
                throw;
            }

            Log.Information($"Text entered to element. Text: {value}, Locator: {Locator}");

            return PageObject;
        }
    }
}
