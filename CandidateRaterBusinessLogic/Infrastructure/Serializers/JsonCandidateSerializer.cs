using CandidateRatingLibrary.Core.Interfaces;
using CandidateRatingLibrary.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CandidateRatingLibrary.Infrastructure.Serializers
{
    public class JsonCandidateSerializer : ICandidateSerializer
    {
        public Candidate GetCandidateFromString(string candidateString) => JsonConvert.DeserializeObject<Candidate>(candidateString)!;
    }
}
