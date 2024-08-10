
Inventory<Item> inventory = new Inventory<Item>();


Item item1 = new Item();
item1.Name = "Daler";
item1.Category = "Developer1";
item1.MyEnum = Type.HomeItem;
inventory.AddItem(item1);

Item item2 = new Item();
item2.Name = "Davron";
item2.Category = "Developer2";
item2.MyEnum = Type.OfficeItem;
inventory.AddItem(item2);

Item item3 = new Item();
item3.Name = "Fakhriddin";
item3.Category = "Developer3";
item3.MyEnum = Type.WorkItem;
inventory.AddItem(item3);

Item item4 = new Item();
item4.Name = "Komron";
item4.Category = "Developer4";
item3.MyEnum = Type.WorkItem;
inventory.AddItem(item4);
foreach (var item in inventory.GetAllItems())
{
    System.Console.WriteLine($"Name: {item.Name} - Categori: {item.Category} - Type: {item.MyEnum}");
}


inventory.RemoveItem(item4);

System.Console.WriteLine();
foreach (var item in inventory.GetAllItems())
{
    System.Console.WriteLine($"Name: {item.Name} - Categori: {item.Category} - Type: {item.MyEnum}");
}

string category = "Developer2"!;
System.Console.WriteLine();
var itemBycat = inventory.GetItemsByCategory(category);
System.Console.WriteLine($"Name: {itemBycat.Name} - Categori: {itemBycat.Category} - Type: {itemBycat.MyEnum}");

var newEnum = Type.HomeItem;
var resEnum = inventory.GetItemsByType(newEnum);
System.Console.WriteLine();
System.Console.WriteLine($"Name: {resEnum.Name} - Categori: {resEnum.Category} - Type: {resEnum.MyEnum}");