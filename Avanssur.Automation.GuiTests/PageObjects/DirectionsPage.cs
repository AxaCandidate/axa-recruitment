using Avanssur.Automation.GuiTests.Elements;
using OpenQA.Selenium;
using Serilog.Core;

namespace Avanssur.Automation.GuiTests.PageObjects
{
    public class DirectionsPage
    {
        private IWebDriver _driver;

        private Logger _logger;

        public DirectionsPage(IWebDriver driver, Logger logger)
        {
            _driver = driver;
            _logger = logger;
        }

        public TextBox<DirectionsPage> ChooseStartingPoint => new TextBox<DirectionsPage>(this, By.CssSelector("div[guidedhelpid=directions_searchboxes] div#directions-searchbox-0 input"), _driver, _logger);
        
        public TextBox<DirectionsPage> ChooseDestination => new TextBox<DirectionsPage>(this, By.CssSelector("div[guidedhelpid=directions_searchboxes] div#directions-searchbox-1 input"), _driver, _logger);

        public Icon<DirectionsPage> Walking => new Icon<DirectionsPage>(this, By.CssSelector("div.widget-directions-travel-mode-switcher-container div[data-travel_mode='2']"), _driver, _logger);
        
        public Icon<DirectionsPage> Cycling => new Icon<DirectionsPage>(this, By.CssSelector("div.widget-directions-travel-mode-switcher-container div[data-travel_mode='1']"), _driver, _logger);

        public Label<DirectionsPage> FirstResultTime => new Label<DirectionsPage>(this, By.XPath("//div[@id='section-directions-trip-0']//div[contains(@class, 'trip-duration')]"), _driver, _logger);
        
        public Label<DirectionsPage> FirstResultDistance => new Label<DirectionsPage>(this, By.XPath("//div[@id='section-directions-trip-0']//div[contains(@class, 'trip-duration')]/following-sibling::div"), _driver, _logger);

    }
}
