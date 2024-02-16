using CandidateRatingLibrary.Core.Raters;
using System.Data;
using System.Linq;
using Xunit;

namespace CandidateRater.Tests
{
    public class DeveloperRaterTest
    {
        [Fact]
        public void LogsContainExperienceRequiredMessage()
        {
            var candidate = new Candidate() { Type = CandidateType.Developer };
            var logger = new FakeLogger();
            var rater =new RaterFactory(logger).Create(candidate);
            rater.Rate(candidate);
            Assert.Equal("Experience is needed!", logger.LoggedMessages.Last());
        }

        [Fact]
        public void RatingIs59()
        {
            var candidate = new Candidate()
            {
                Type = CandidateType.Developer,
                Experience = 17,
                HasCertificates = true,
                HasQualifications = true,
                HasWorkingVisa = true,
                DateOfBirth = new DateTime(1978, 6, 5)
            };
            var logger = new FakeLogger();
            var result = new RaterFactory(logger).Create(candidate).Rate(candidate);
            Assert.Equal(59, result);
        }
    }
}
