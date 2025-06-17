using SmartHostelManagementSystem.Models;
using System.Text.Json;

namespace SmartHostelManagementSystem.Services
{
    public class ComplaintService
    {
        public async Task SubmitComplaintAsync(Complaint complaint)
        {
            string fileName = "complaints.json";

            List<Complaint> allComplaints = new();

            if (File.Exists(fileName))
            {
                string json = await File.ReadAllTextAsync(fileName);
                allComplaints = JsonSerializer.Deserialize<List<Complaint>>(json) ?? new();
            }

            allComplaints.Add(complaint);

            await File.WriteAllTextAsync(fileName, JsonSerializer.Serialize(allComplaints));
        }
    }
}
