
public class ClientManager<T> where T :  Client //,IndividualClient, CorporateClient
{
    List<T> values = [];

    public void CreateClient(T client)
    {
        var res = values.Find(x => x.ClientId == client.ClientId);
        if(res != null)
        {
            System.Console.WriteLine("Не нашлось!");
            return;
        }

        values.Add(client);
    }

    public List<T> GetAllClient()
    {
        return values;
    }

    public T? GetById(int id)
    {
        var res = values.Find(x => x.ClientId == id);
        if(res == null)
        {
            System.Console.WriteLine("Не удвлось найти по ID");
            return null;
        }

        return res;
    }

    public void DeleteClient(int id)
    {
        var res = values.Find(x => x.ClientId == id);
        if(res == null)
        {
            System.Console.WriteLine("Не удалось удалить клиента!");
            return;
        }
        values.Remove(res);
    }
}