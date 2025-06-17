namespace SmartHostelManagementSystem.Models;

public class Room
{
    
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }
    public List<string> Occupants { get; set; } = new List<string>();

}
