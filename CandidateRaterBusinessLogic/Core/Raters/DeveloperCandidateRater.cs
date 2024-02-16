using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;
using System;

namespace CandidateRatingLibrary.Core.Raters
{
    public class DeveloperCandidateRater : Rater
    {
        public DeveloperCandidateRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Candidate candidate)
        {
            Logger.Log("Rating Developer candidate...");
            Logger.Log("Validating candidate...");
            if (Validate(candidate))
                return (candidate.Experience * 2) +
                       (candidate.HasCertificates ? 10 : 0) +
                       (candidate.HasWorkingVisa ? 5 : 0) +
                       (candidate.HasQualifications ? 10 : 0) +
                       (candidate.HasAgeProblem ? -30 : 0);
            return -1;
        }
    }
}
