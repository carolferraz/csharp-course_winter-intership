using OverlapVirtualOverrideBase.Entities;

namespace OverlapVirtualOverrideBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1000, "Alex", 100.0);
            Account account2 = new SavingAccount(1002, "Maria", 100.0, 0.01);

            account1.WithDraw(10.0);
            account2.WithDraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}