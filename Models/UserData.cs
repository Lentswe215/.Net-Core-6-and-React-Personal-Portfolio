using LenMamPortfolio.Helpers;

namespace LenMamPortfolio.Models
{

    public class UserData
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public UserTypes UserType { get; set; }
        public string? EmailAddress { get; set; }
        public string? CurrentPassword { get; set; }
        public string? LassPassword { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool LockedOut { get; set; }
        public bool IsDeleted { get; set; }
    }
}
