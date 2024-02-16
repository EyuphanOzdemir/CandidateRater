using CandidateRatingLibrary.Core.Models;

namespace CandidateRatingLibrary.Core.Interfaces
{
    public interface ICandidateSerializer
    {
        Candidate GetCandidateFromString(string candidateString);
    }
}
