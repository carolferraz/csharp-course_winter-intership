using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular da conta: ");
            string accountOwner = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char hasInicialBalance = char.Parse(Console.ReadLine());

            if (hasInicialBalance == 's' || hasInicialBalance == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double inicialAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
                bankAccount = new BankAccount(accountNumber, accountOwner, inicialAmount);
                
            } else bankAccount = new BankAccount(accountNumber, accountOwner)

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(bankAccount);

            Console.Write("Entre um valor para depósito: ");
            double amount = double.Parse(Console.Readine(), CultureInfo.InvariantCulture);
            bankAccount.AddBalance(amount);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bankAccount.RemoveBalance(amount);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(bankAccount);

        }
    }
}