using System.Collections.Generic;

namespace BlazorBaseProfileCascade.Data
{
    public class CandidateProfile : CandidateProfileBase
    {
        public CandidateProfile()
        {
            BaTechniques = new List<string>();
            UxAndDesign = new List<string>();
            Tools = new List<string>();
            Certifications = new List<string>();
        }

        public IList<string> BaTechniques { get; set; }

        public IList<string> UxAndDesign { get; set; }

        public IList<string> Tools { get; set; }

        public IList<string> Certifications { get; set; }
    }
}