using IServer;
public class ServerEvent : IServiseEvent
{

    List<Event> events = [];
    public void AddEvent(Event even)
    {
        Event? res = events.Find(x => x.Title == even.Title);
        if (res != null)
        {
            System.Console.WriteLine("Event - не получилось сохранить!");
            return;
        }
        events.Add(even);
    }

    public void DeleteEvemt(string title)
    {
        var res = events.Find(x => x.Title == title);
        if (res == null)
        {
            System.Console.WriteLine("Не удалось найти Event");
            return;
        }
        events.Remove(res);
    }

    public List<Event> GetAllEvent()
    {
        return events;
    }

    public Event? GetEvent(DateTime dateTimeStart, DateTime dateTimeEnd)
    {
        var res = events.Find(x => x.StartTime == dateTimeStart && x.EndTime == dateTimeEnd);
        if (res == null)
        {
            System.Console.WriteLine("Не удалось найти Event по времени!");
            return null;
        }
        return res;
    }

}