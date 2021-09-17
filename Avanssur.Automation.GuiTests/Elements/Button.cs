using OpenQA.Selenium;
using Serilog.Core;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class Button<T> : ElementClickable<T>
    {
        public Button(T pageObject, By locator, IWebDriver driver, Logger logger) : base(pageObject, locator, driver, logger)
        {
        }
    }
}
