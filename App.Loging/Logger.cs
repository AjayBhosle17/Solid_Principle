using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Loging
{
    public class Logger : ILogger
    {
        private readonly ILog _log;
        private readonly bool IsLoggingEnabled = false;

        public Logger(ILog log)
        {
            _log = log;
            IsLoggingEnabled =
               bool.Parse(ConfigurationManager.AppSettings["EnableLogging"]);
        }

        public void Debug(string message)
        {
            if (IsLoggingEnabled)
                _log.Debug(message);
        }

        public void Error(string message, Exception ex = null)
        {
            if (IsLoggingEnabled)
                _log.Error(message, ex);
        }

        public void Info(string message)
        {
            if (IsLoggingEnabled)
                _log.Info(message);
        }

        public void Warn(string message)
        {
            if (IsLoggingEnabled)
                _log.Warn(message);
        }
    }
}
