using System;

class BankAccount
{
    private int balance;

    public void Deposit(int amount)
    {
        balance += amount;
    }

    public void Withdraw(int amount)
    {
        if(amount > balance)
        {
            Console.WriteLine("残高が不足しています！");
        }
        else
        {
            balance -= amount;
        }
    }

    public int GetBalance()
    {
        return balance;
    }

    public BankAccount()
    {
        balance = 0;
    }

    public void Transfer(BankAccount dest, int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("残高が不足しています！");
        }
        else
        {
            balance -= amount;
            dest.balance += amount;
        }
    }
}

class Hellooooooon
{
    public static void Main()
    {
        var myAvvount = new BankAccount();

        Console.WriteLine("10000円預金します。");
        myAvvount.Deposit(10000);
        Console.WriteLine("現在の残高: {0}", myAvvount.GetBalance());

        Console.WriteLine("5000円引き出します。");
        myAvvount.Withdraw(5000);
        Console.WriteLine("現在の残高: {0}", myAvvount.GetBalance());

        Console.WriteLine("8000円引き出します。");
        myAvvount.Withdraw(8000);
        Console.WriteLine("現在の残高: {0}", myAvvount.GetBalance());

    }

}
