using CandidateRatingLibrary.Core.Interfaces;

namespace CandidateRatingLibrary.Infrastructure.Loggers
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
        }
    }
}
