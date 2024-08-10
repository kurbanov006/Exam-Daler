

public class TransactionManager
{

    List<Transaction> transactions = [];

    public void CreateTransaction(Transaction transaction)
    {
        var res = transactions.Find(x => x.Id == transaction.Id);
        if(res != null)
        {
            System.Console.WriteLine("Не удалось добавить транзакцию!");
            return;
        }
        transactions.Add(transaction);
    }

    public Transaction? GetTransactionOneYear(DateTime dateTime)
    {
        var res = transactions.Find(x => x.Date.Year == dateTime.Year);
        if(res == null)
        {
            System.Console.WriteLine("не удалось найти транзакции");
            return null;
        }
        return res;
    }

    public Transaction? GetTransactionFirstandLast()
    {
        System.Console.WriteLine(transactions[0]);
        transactions.Reverse();
        return transactions[0];
    }
}