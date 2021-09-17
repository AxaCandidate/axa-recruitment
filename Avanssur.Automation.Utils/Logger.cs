using Serilog;
using System.IO;

namespace Avanssur.Automation.Utils
{
    public sealed class Logger
    {
        private static Serilog.Core.Logger _instance;

        public static Serilog.Core.Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoggerConfiguration()
                        .MinimumLevel.Information()
                        .WriteTo.File($@"{new Properties.Settings().LogsFilePath}", rollingInterval: RollingInterval.Day)
                        .CreateLogger();
                }
                return _instance;
            }
        }
    }
}
