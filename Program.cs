// See https://aka.ms/new-console-template for more information
using SmartHostelManagementSystem.Models;
using SmartHostelManagementSystem.Services;

class Program
{
    static async Task Main()
    {
        var student = new Student
        {
            ID = 1,
            Name = "Alice"
        };
        var room = new Room
        {
            RoomNumber = 101,
            Capacity = 2
        };
        var roomService = new RoomService();

        try
        {
            await roomService.AllocateRoomAsync(student, room);
            Console.WriteLine("✅ Room allocated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
        }
    }
}

