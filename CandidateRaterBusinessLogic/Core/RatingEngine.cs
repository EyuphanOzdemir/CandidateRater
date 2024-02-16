using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Raters;

namespace CandidateRatingLibrary.Core
{
    /// <summary>
    /// The RatingEngine reads the candidate application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly ILogger _logger;
        private readonly ICandidateSource _candidateSource;
        private readonly ICandidateSerializer _candidateSerializer;
        private readonly RaterFactory _raterFactory;

        public decimal Rating { get; set; }

        public RatingEngine(ILogger logger,
            ICandidateSource candidateSource,
            ICandidateSerializer candidateSerializer,
            RaterFactory raterFactory)
        {
            _logger = logger;
            _candidateSource = candidateSource;
            _candidateSerializer = candidateSerializer;
            _raterFactory = raterFactory;
        }

        public decimal Rate()
        {
            _logger.Log("Starting rate...");

            _logger.Log("Loading candidate info...");

            string candidateJson = _candidateSource.GetCandidateFromSource();

            var candidate = _candidateSerializer.GetCandidateFromString(candidateJson);

            if (candidate != null)
            {
                var rater = _raterFactory.Create(candidate);
                Rating = rater.Rate(candidate);
                _logger.Log("Rating completed successfully.");
            }
            else
               _logger.Log("Rating failed because Candidate info could not get!");
            return Rating;
        }
    }
}
