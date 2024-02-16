using CandidateRatingLibrary.Core;
using CandidateRatingLibrary.Core.Raters;
using CandidateRatingLibrary.Infrastructure.CandidateSources;
using CandidateRatingLibrary.Infrastructure.Serializers;
using Newtonsoft.Json;
using Xunit;

namespace CandidateRater.Tests
{
    public class RatingEngineRate
    {
        private RatingEngine _engine;
        private FakeLogger _logger;
        private StringCandidateSource _candidateSource;
        private JsonCandidateSerializer _candidateSerializer;
        public RatingEngineRate()
        {
            _logger = new FakeLogger();
            _candidateSource = new StringCandidateSource();
            _candidateSerializer = new JsonCandidateSerializer();

            _engine = new RatingEngine(_logger,
                                       _candidateSource,
                                       _candidateSerializer,
                                       new RaterFactory(_logger));
        }

        [Fact]
        public void TooYoungTest()
        {
            var candidate = new Candidate
            {
                Type = CandidateType.Sales,
                Experience = 1,
                DateOfBirth = new DateTime(1921, 1, 1),
            };
            string json = JsonConvert.SerializeObject(candidate);
            _candidateSource.CandidateString = json;

            _engine.Rate();
            var result = _engine.Rating;

            Assert.Equal(-18.5m, result);
        }
    }
}
