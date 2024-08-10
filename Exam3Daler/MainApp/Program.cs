
ClientManager<Client> ServiseClient = new ClientManager<Client>();
Client client1 = new Client();
client1.ClientId = 1;
client1.ContactInfo = "Get Food";
client1.Name = "Daler";
ServiseClient.CreateClient(client1);

CorporateClient client2 = new CorporateClient();
client2.ClientId = 2;
client2.ContactInfo = "Get Portret";
client2.Name = "Davron";
client2.TaxId = 2;
ServiseClient.CreateClient(client2);

IndividualClient client3 = new IndividualClient();
client3.ClientId = 3;
client3.ContactInfo = "Meow meow";
client3.Name = "Cat";
client3.GenDer = Gender.Female;
ServiseClient.CreateClient(client3);


foreach (var item in ServiseClient.GetAllClient())
{
    System.Console.WriteLine($"Name: {item.Name} - Contract: {item.ContactInfo} - Name: {item.Name}");
}
System.Console.WriteLine();

int id = 2;
var res = ServiseClient.GetById(id);
System.Console.WriteLine($"Name: {res.Name} - Contract: {res.ContactInfo} - Name: {res.Name}");

ServiseClient.DeleteClient(2);

System.Console.WriteLine();
foreach (var item in ServiseClient.GetAllClient())
{
    System.Console.WriteLine($"Name: {item.Name} - Contract: {item.ContactInfo} - Name: {item.Name}");
}

