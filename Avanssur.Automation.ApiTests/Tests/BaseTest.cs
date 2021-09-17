using Avanssur.Automation.Utils;
using NUnit.Framework;

namespace Avanssur.Automation.ApiTests.Tests
{
    public class BaseTest
    {
        private Properties.Settings _settings;

        private Properties.Settings Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = new Properties.Settings();
                }
                return _settings;
            }
        }

        protected string BaseUrlApi => Settings.BaseUrlApi;

        protected Serilog.Core.Logger Log => Logger.Instance;

        [SetUp]
        protected void RunBeforeEachTest()
        {
            var currentTestMethodName = TestContext.CurrentContext.Test.MethodName;
            Log.Information($"API Test started: {currentTestMethodName}");
        }

        [TearDown]
        protected void RunAfterEachTest()
        {
            var currentTestMethodName = TestContext.CurrentContext.Test.MethodName;
            var currentTestResult = TestContext.CurrentContext.Result.Outcome;
            var currentTestMessage = TestContext.CurrentContext.Result.Message;
            Log.Information($"API Test finished: {currentTestMethodName}. Result: {currentTestResult}. Message: {currentTestMessage ?? "---"}\n");
        }
    }
}
