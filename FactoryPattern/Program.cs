// See https://aka.ms/new-console-template for more information
IAccountFactory accountFactory = new AccountFactory();

var savingAccount = accountFactory.GetAccoutType("SAVINGS");
Console.WriteLine("Saving account balance: " + savingAccount.Balance);

var currentAccount = accountFactory.GetAccoutType("CURRENT");
Console.WriteLine("Current account balance: " + currentAccount.Balance);

public abstract class AccoutType
{
    public string Balance { get; set; }
}

public class SavingsAccount : AccoutType
{
    public SavingsAccount()
    {
        Balance = "10000 Rs";
    }
}

public class CurrentAccount : AccoutType
{
    public CurrentAccount()
    {
        Balance = "20000 Rs";
    }
}

//Creator
public interface IAccountFactory
{
    AccoutType GetAccoutType(string accountName);
}

//Concrete Creator
public class AccountFactory : IAccountFactory
{
    public AccoutType GetAccoutType(string accountName)
    {
        if (accountName.Equals("SAVINGS", StringComparison.OrdinalIgnoreCase))
        {
            return new SavingsAccount();
        }
        else if (accountName.Equals("CURRENT", StringComparison.OrdinalIgnoreCase))
        {
            return new CurrentAccount();
        }
        else
        {
            throw new ArgumentException("Invalid account name");
        }
    }
}