
public class ServiseBook 
{
    List<Booking> bookings = [];

    public void CreateBook(Booking booking)
    {
        var res = bookings.Find(x => x._room.RoomNumber == booking._room.RoomNumber);
        if(res != null)
        {
            System.Console.WriteLine("Не удалось добавить ");
            return;
        }

        bookings.Add(booking);
    }

    // public void ProverkaBook()
}