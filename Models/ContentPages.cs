using LenMamPortfolio.Helpers;

namespace LenMamPortfolio.Models
{
    public class ContentPages
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public PageTypes PageType { get; set; }
        public string? MetaData { get; set; }
        public DateTime LastModified { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
