using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;

namespace CandidateRatingLibrary.Core.Raters
{
    public class UnknownCandidateRater : Rater
    {
        public UnknownCandidateRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Candidate candidate)
        {
            Logger.Log("Unknown policy type");
            return -1m;
        }
    }
}
