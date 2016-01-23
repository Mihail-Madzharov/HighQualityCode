using System;
using SOLID_Principles_in_Software_Design.Contracts;
using SOLID_Principles_in_Software_Design.Enumeration;

namespace SOLID_Principles_in_Software_Design.Layouts
{
    public abstract class Layout : ILayout
    {
        public abstract string Format(ReportLevels report, string levels, DateTime dateTime);
    }
}
