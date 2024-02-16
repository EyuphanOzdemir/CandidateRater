using System;
using System.ComponentModel.DataAnnotations;

namespace CandidateRatingLibrary.Core.Models
{
    public class Candidate
    {
        public CandidateType Type{ get; set; }

        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public decimal Experience { get; set; } = -1; //in years
        public bool HasCertificates { get; set;}

        public bool HasQualifications { get; set; }

        public bool HasWorkingVisa { get; set;}

        public int Age =>DateTime.Now.Year - DateOfBirth.Year;

        public bool HasAgeProblem => Age > 70 || Age < 18;

    }
}
