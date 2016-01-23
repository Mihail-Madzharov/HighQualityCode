using System;
using Microsoft.SqlServer.Server;
using SOLID_Principles_in_Software_Design.Enumeration;

namespace SOLID_Principles_in_Software_Design.Contracts
{
    public interface ILayout
    {
        string Format(ReportLevels report, string levels, DateTime dateTime);
    }
}