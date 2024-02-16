using CandidateRatingLibrary.Core.Interfaces;

namespace CandidateRatingLibrary.Infrastructure.CandidateSources
{
    public class StringCandidateSource : ICandidateSource
    {
        public string CandidateString { get; set; } = "";

        public string GetCandidateFromSource()
        {
            return CandidateString;
        }
    }
}
