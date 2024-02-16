using Xunit;
using CandidateRatingLibrary.Infrastructure.Serializers;
using Common;
using System.Text.Json;

namespace CandidateRater.Tests
{
    public class JsonSerializerTests
    {
        [Fact]
        public void ReturnsDefaultCandidateFromEmptyJsonString()
        {
            var inputJson = "{}";
            var serializer = new JsonCandidateSerializer();

            var result = serializer.GetCandidateFromString(inputJson);

            var candidate = new Candidate();
            AssertCandidatesEqual(result, candidate);
        }

        [Fact]
        public void ValidateJsonWithValues()
        {
            var candidate = new Candidate()
            {
                DateOfBirth = new DateTime(1978, 6, 5),
                FullName = "Eyuphan Ozdemir",
                HasCertificates = true,
                HasQualifications = true
            };
            var inputJson = JsonSerializer.Serialize(candidate);
            
            var serializer = new JsonCandidateSerializer();

            var result = serializer.GetCandidateFromString(inputJson);

            AssertCandidatesEqual(result, candidate);
        }

        private static void AssertCandidatesEqual(Candidate result, Candidate candidate)
        {
            Assert.True(Reflection.ArePropertiesEqual(result, candidate));
        }
    }
}
