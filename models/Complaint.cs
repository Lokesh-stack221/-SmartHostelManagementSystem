namespace SmartHostelManagementSystem.Models
{
    public class Complaint
    {
        public required string StudentId { get; set; }
        public required string Description { get; set; }
        public DateTime DateRaised { get; set; }
    }
}
