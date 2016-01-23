
namespace SOLID_Principles_in_Software_Design.Appenders
{
    using System;
    using Contracts;
    using Enumeration;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string msg, ReportLevels report, DateTime dateTime)
        {
            string tempMsg = this.Layout.Format(report, msg, dateTime);

            Console.WriteLine(tempMsg);
        }
    }
}