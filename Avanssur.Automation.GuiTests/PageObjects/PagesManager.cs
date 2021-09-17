using OpenQA.Selenium;
using Serilog.Core;
using System;
using System.Collections.Generic;

namespace Avanssur.Automation.GuiTests.PageObjects
{
    public class PagesManager
    {
        private readonly Dictionary<Type, object> _pages = new Dictionary<Type, object>();

        private IWebDriver _driver;

        private Logger _logger;

        public PagesManager(IWebDriver driver, Logger logger)
        {
            _driver = driver;
            _logger = logger;
        }

        public T Create<T>()
        {
            var isInCache = _pages.ContainsKey(typeof(T));

            if (!isInCache)
            {
                var newInstance = (T)Activator.CreateInstance(typeof(T), _driver, _logger);

                _pages.Add(typeof(T), newInstance);
            }

            return (T)_pages[typeof(T)];
        }
    }
}
