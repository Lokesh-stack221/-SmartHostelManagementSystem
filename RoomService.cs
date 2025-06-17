using SmartHostelManagementSystem.Models;
using System.Text.Json;

namespace SmartHostelManagementSystem.Services;

public class RoomService
{
    public async Task AllocateRoomAsync(Student student, Room room)
    {
       
        student.RoomNumber = room.RoomNumber;

        Console.WriteLine("🔄 Saving student and room data to file...");

        // Save to files
        await File.WriteAllTextAsync("studentData.json", JsonSerializer.Serialize(student));
        await File.WriteAllTextAsync("roomData.json", JsonSerializer.Serialize(room));

        Console.WriteLine("✅ Files saved.");
    }
}
