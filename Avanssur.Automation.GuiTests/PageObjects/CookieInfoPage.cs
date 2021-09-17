using Avanssur.Automation.GuiTests.Elements;
using OpenQA.Selenium;
using Serilog.Core;

namespace Avanssur.Automation.GuiTests.PageObjects
{
    public class CookieInfoPage
    {
        private IWebDriver _driver;

        private Logger _logger;

        public CookieInfoPage(IWebDriver driver, Logger logger)
        {
            _driver = driver;
            _logger = logger;
        }

        public Button<CookieInfoPage> IAgree => new Button<CookieInfoPage>(this, By.XPath("(//form//button) | (//div[@class='box']//input[@type='submit'])"), _driver, _logger);  // different DOM for chrome and edge
    }
}
