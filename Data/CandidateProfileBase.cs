using System.Collections.Generic;

namespace BlazorBaseProfileCascade.Data
{
    public class CandidateProfileBase
    {
        public string EmailAddress { get; set; }

        public string Summary { get; set; }

        public IList<string> Strengths { get; set; } = new List<string>();

        public IList<string> Expertise { get; set; } = new List<string>();
    }
}