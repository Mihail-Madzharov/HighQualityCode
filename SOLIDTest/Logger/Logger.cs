
namespace SOLIDTest.Logger
{
    using System;
    using System.Collections.Generic;
    using SOLID_Principles_in_Software_Design.Contracts;
    using SOLID_Principles_in_Software_Design.Enumeration;

    public class Logger : ILogger
    {
        private IList<IAppender> Appenders { get; }

        public Logger(params IAppender[] appender)
        {
            Appenders = new List<IAppender>(appender);
        }

        public void Error(string msg)
        {
            Log(msg, ReportLevels.Error);
        }

        public void Info(string msg)
        {
            Log(msg, ReportLevels.Info);

        }

        public void Warn(string msg)
        {
            Log(msg, ReportLevels.Warn);
        }

        public void Critical(string info)
        {
            Log(info, ReportLevels.Warn);
        }

        public void Fatal(string msg)
        {
            Log(msg, ReportLevels.Fatal);
        }

        private void Log(string log, ReportLevels report)
        {
            var dateTime = DateTime.Now;

            foreach (var appender in Appenders)
            {
                appender.Append(log, report, dateTime);
            }
        }
    }
}
