using CandidateRatingLibrary.Core.Interfaces;
using System.IO;

namespace CandidateRatingLibrary.Infrastructure.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var stream = File.AppendText("log.txt"))
            {
                stream.WriteLine(message);
                stream.Flush();
            }
        }
    }
}
