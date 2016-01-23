using System;
using SOLID_Principles_in_Software_Design.Enumeration;

namespace SOLID_Principles_in_Software_Design.Layouts
{
    public class SimpleLayout : Layout
    {
        private const string FormatType = "{0} - {1} - {2}";

        public override string Format(ReportLevels report, string levels, DateTime dateTime)
        {
            return string.Format(FormatType, dateTime, report, levels);
        }
    }
}
