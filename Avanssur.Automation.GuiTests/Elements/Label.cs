using OpenQA.Selenium;
using Serilog.Core;

namespace Avanssur.Automation.GuiTests.Elements
{
    public class Label<T> : Element<T>
    {
        public Label(T pageObject, By locator, IWebDriver driver, Logger logger) : base(pageObject, locator, driver, logger)
        {
        }

        public string GetText()
        {
            var element = WaitForElementToBeVisible();

            string text;
            try
            {
                text = element.Text;
            }
            catch (StaleElementReferenceException)
            {
                Log.Error($"Cannot get text from element. Locator: {Locator}");
                throw;
            }

            Log.Information($"Text got from element. Text: {text}, Locator: {Locator}");

            return text;
        }
    }
}
