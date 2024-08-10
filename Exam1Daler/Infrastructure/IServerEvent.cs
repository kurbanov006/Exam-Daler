

namespace IServer;

public interface IServiseEvent
{
    public void AddEvent(Event even);
    public void DeleteEvemt(string title);
    public Event? GetEvent(DateTime dateTime, DateTime dateTimeEnd);
    public List<Event> GetAllEvent();
}