using System;
using SOLID_Principles_in_Software_Design.Contracts;
using SOLID_Principles_in_Software_Design.Enumeration;
using SOLID_Principles_in_Software_Design.Layouts;

namespace SOLID_Principles_in_Software_Design.Appenders
{
    public abstract class Appender : IAppender
    {

        protected Appender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get; }

        public abstract void Append(string msg, ReportLevels report, DateTime dateTime);
    }
}
