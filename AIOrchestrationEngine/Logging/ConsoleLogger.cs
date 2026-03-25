using System;
using AIOrchestrationEngine.Core.Interfaces;

namespace AIOrchestrationEngine.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}