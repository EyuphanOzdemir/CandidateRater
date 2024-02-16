using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;

namespace CandidateRatingLibrary.Core.Raters
{
    public abstract class Rater
    {
        public ILogger Logger { get; set; }

        public Rater(ILogger logger)
        {
            Logger = logger;
        }

        public bool Validate(Candidate candidate)
        {
            if (candidate.Experience < 0)
            {
                Logger.Log("Experience is needed!");
                return false;
            }

            if (candidate.DateOfBirth == default)
            {
                Logger.Log("Date of birth is needed!");
                return false;
            }
            return true;
        }

        public abstract decimal Rate(Candidate candidate);
    }
}
