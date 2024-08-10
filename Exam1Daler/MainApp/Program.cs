

ServerEvent serverEvent = new ServerEvent();
Event event1 = new Event();
event1.Title = "Exam";
event1.Description = "Exam students in Softclab";
DateTime dateTimeStart1 = new DateTime(2024, 08, 10, 10, 00, 00);
event1.StartTime = dateTimeStart1;
DateTime dateTimeEnd1 = new DateTime(2024, 08, 10, 12, 00, 00);
event1.EndTime = dateTimeEnd1;

serverEvent.AddEvent(event1);



Event event3 = new Event();
event3.Title = "Restorant";
event3.Description = "Eat food";
DateTime dateTimeStart3 = new DateTime(2024, 08, 18, 12, 00, 00);
event3.StartTime = dateTimeStart3;
DateTime dateTimeEnd3 = new DateTime(2024, 08, 18, 13, 00, 00);
event3.EndTime = dateTimeEnd3;

serverEvent.AddEvent(event3);
// обектора сохтем



foreach(var item in serverEvent.GetAllEvent())
{
    System.Console.WriteLine($"Title: {item.Title} - Description: {item.Description} - TimeStart: {item.StartTime} - TimeEnd: {item.EndTime}");
}
// пеш ай уд
string nameDelEvent = "Restorant";
serverEvent.DeleteEvemt(nameDelEvent);

Event event2 = new Event();
event2.Title = "Zoo ";
event2.Description = "See animal";
DateTime dateTimeStart2 = new DateTime(2024, 10, 13, 10, 30, 00);
event2.StartTime = dateTimeStart2;
DateTime dateTimeEnd2 = new DateTime(2024, 10, 13, 12, 00, 00);
event2.EndTime = dateTimeEnd2;

serverEvent.AddEvent(event2);
System.Console.WriteLine();
foreach(var item in serverEvent.GetAllEvent())
{
    System.Console.WriteLine($"Title: {item.Title} - Description: {item.Description} - TimeStart: {item.StartTime} - TimeEnd: {item.EndTime}");
}
// бад ай уд


