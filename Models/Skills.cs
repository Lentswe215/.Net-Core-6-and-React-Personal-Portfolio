using LenMamPortfolio.Helpers;

namespace LenMamPortfolio.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SkillTypes SkillType { get; set; }
        public double Level { get; set; }
        public int AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int status { get; set; }
    }
}
