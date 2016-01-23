using System;
using SOLID_Principles_in_Software_Design.Enumeration;

namespace SOLID_Principles_in_Software_Design.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(string msg, ReportLevels report, DateTime dateTime);
    }
}