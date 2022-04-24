namespace LenMamPortfolio.Models
{
    public class ContactMessages
    {
        public int Id { get; set; }
        public string? FromFullName { get; set; }
        public int MobileNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        public string? SenderIP { get; set; }
    }
}
