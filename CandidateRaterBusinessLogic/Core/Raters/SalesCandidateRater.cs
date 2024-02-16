using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;

namespace CandidateRatingLibrary.Core.Raters
{
    public class SalesCandidateRater : Rater
    {
        public SalesCandidateRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Candidate candidate)
        {
            Logger.Log("Rating Sales Candidate policy...");
            Logger.Log("Validating candidate...");
            if (Validate(candidate))
                return (candidate.Experience * 1.5m) +
                       (candidate.HasWorkingVisa ? 5 : 0) +
                       (candidate.HasQualifications ? 5 : 0) +
                       (candidate.HasAgeProblem ? -20 : 0);
            return -1;
        }
    }
}
