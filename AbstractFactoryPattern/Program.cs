// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.AbstractClass;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Models;


List<string> accNames = new List<string> { "B1-456", "B1-987", "B2-222" };
for (int i = 0; i < accNames.Count; i++)
{
    AccountTypeFactory anAbstractFactory = AccountFactoryProvider.GetAccountTypeFactory(accNames[i]);
    if (anAbstractFactory == null)
    {
        Console.WriteLine("Invalid " + (accNames[i]));
    }
    else
    {
        ISavingAccount savingAccount = anAbstractFactory.SavingAccountFactory("Hello saving " + accNames[i]);
        ICurrentAccount currentAccount = anAbstractFactory.CurrentAccountFactory("Hello Current " + accNames[i]);
    }
}
Console.ReadLine();

//Concrete Creator
public class Bank1Factory : AccountTypeFactory
{
    public override ICurrentAccount CurrentAccountFactory(string message)
    {
        return new CurrentAccount(message);
    }

    public override ISavingAccount SavingAccountFactory(string message)
    {
        return new SavingsAccount(message);
    }
}

public class AccountFactoryProvider
{
    public static AccountTypeFactory GetAccountTypeFactory(string accountName)
    {

        if (accountName.Contains("B1")) { return new Bank1Factory(); }
        else return null;
    }
}