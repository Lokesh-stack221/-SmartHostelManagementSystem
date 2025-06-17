// See https://aka.ms/new-console-template for more information
using SmartHostelManagementSystem.Models;
using SmartHostelManagementSystem.Services;

Complaint complaint = new Complaint
{
    StudentId = "S001",
    Description = "Wi-Fi not working",
    DateRaised = DateTime.Now
};

ComplaintService service = new ComplaintService();

await service.SubmitComplaintAsync(complaint);

Console.WriteLine("Complaint submitted successfully.");
