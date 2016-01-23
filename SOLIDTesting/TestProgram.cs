using SOLIDTest.Logger;
using SOLID_Principles_in_Software_Design.Appenders;
using SOLID_Principles_in_Software_Design.Contracts;
using SOLID_Principles_in_Software_Design.Layouts;

namespace SOLIDTesting
{
    class TestProgram
    {
        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();

            IAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info($"User {"Pesho"} successfully registered.");
        }
    }
}
