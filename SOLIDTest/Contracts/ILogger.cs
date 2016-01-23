namespace SOLID_Principles_in_Software_Design.Contracts
{
    public interface ILogger
    {
        void Error(string error);

        void Info(string info);

        void Warn(string error);

        void Critical(string info);

        void Fatal(string error);
    }
}
