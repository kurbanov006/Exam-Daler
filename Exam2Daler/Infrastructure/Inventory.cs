public class Inventory<T> where T : Item
{
    List<Item> items = [];

    public void AddItem(T item)
    {
        var res = items.Find(x => x.Name == item.Name);
        if (res != null)
        {
            System.Console.WriteLine("Не получилось добавить!");
            return;
        }
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        var res = items.Find(x => x.Name == item.Name);
        if (res == null)
        {
            System.Console.WriteLine("Не удалось удалить!");
            return;
        }
        items.Remove(res);
    }

    public Item? GetItemsByCategory(string category)
    {
        var res = items.Find(x => x.Category == category);
        if(res == null)
        {
            System.Console.WriteLine("Не удалось найти по категории");
            return null;
        }
        return res;
    }

    public Item? GetItemsByType(Type type)
    {
        var res = items.Find(x => x.MyEnum == type);
        if(res == null)
        {
            System.Console.WriteLine("Не удалось найти по Enum Type");
            return null;
        }
        return res;
    }

    public List<Item> GetAllItems()
    {
        return items;
    }
}