using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;
using System;

namespace CandidateRatingLibrary.Core.Raters
{
    public class RaterFactory
    {
        private readonly ILogger _logger;

        public RaterFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Rater Create(Candidate candidate)
        {
            try
            {
                var className = $"CandidateRatingLibrary.Core.Raters.{candidate.Type}CandidateRater";
                var raterClass = Type.GetType(className);
                return (Rater)Activator.CreateInstance(raterClass,
                                                       new object[] { _logger })!;
            }
            catch
            {
                return new UnknownCandidateRater(_logger);
            }
        }
    }
}
