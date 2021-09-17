using Avanssur.Automation.GuiTests.Elements;
using OpenQA.Selenium;
using Serilog.Core;
namespace Avanssur.Automation.GuiTests.PageObjects
{
    public class EntryPage
    {
        private IWebDriver _driver;

        private Logger _logger;

        public EntryPage(IWebDriver driver, Logger logger)
        {
            _driver = driver;
            _logger = logger;
        }

        public Icon<EntryPage> Directions => new Icon<EntryPage>(this, By.Id("searchbox-directions"), _driver, _logger);
    }
}
