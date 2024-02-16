using CandidateRatingLibrary.Core.Interfaces;
using System;

namespace CandidateRatingLibrary.Infrastructure.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
