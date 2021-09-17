using OpenQA.Selenium;
using Serilog.Core;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class Icon<T> : ElementClickable<T>
    {
        public Icon(T pageObject, By locator, IWebDriver driver, Logger logger) : base (pageObject, locator, driver, logger)
        {
        }
    }
}
