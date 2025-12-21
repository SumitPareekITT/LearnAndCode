namespace BookSRP.Models;

public class LibraryLocation
{
    public string RoomNumber { get; }
    public string ShelfNumber { get; }

    public LibraryLocation(string roomNumber, string shelfNumber)
    {
        RoomNumber = roomNumber;
        ShelfNumber = shelfNumber;
    }

    public override string ToString()
    {
        return $"Room: {RoomNumber}, Shelf: {ShelfNumber}";
    }
}