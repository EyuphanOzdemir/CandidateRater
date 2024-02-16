using CandidateRatingLibrary.Core.Interfaces;
using System.IO;

namespace CandidateRatingLibrary.Infrastructure.CandidateSources
{
    public class FileCandidateSource : ICandidateSource
    {
        public string FilePath { get; init; }
        public FileCandidateSource(string filePath)
        {

            FilePath = filePath;

        }
        public string GetCandidateFromSource()
        {
            return File.ReadAllText(FilePath);
        }
    }
}
