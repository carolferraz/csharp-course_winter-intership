using UpcastingDownCasting.Entities;

namespace UpcastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING: The superclass can receive any subclass of his own.

            Account account1 = businessAccount; //Here we are converting the account1 object into an businessAccount object. It will receive all the information without problems, because the class BusinessAccount is a Account.
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Here we are instanciating a subclass into a variable of the superclass.
            Account account3 = new SavingAccount(1004, "Anna", 0.0, 0.01); //This exemple is the same as the account2, but using a different type of subclass.

            //DOWNCASTING: Casting the type of a superclass to a subclass.

            BusinessAccount account4 = (BusinessAccount)account2; //"BusinessAccount account4 = account2;" This is not possible, because even though the instance of account2 is of BusinesAccount, the variable has an Account type. So we have to do a casting in the account2 and pass it to the variable that is destined to BusinessAccount.
            BusinessAccount account5 = account2 as BusinessAccount; //We can do the casting using this alternative syntax.

            account4.Loan(100.0); 
            // account2.Loan(100.0); //This is a good exemple to understand: we can access the BusinessAccount methods on account4 because we make a casting on it. However, account 2, even having a BusinessAccount content, still has an Account type, so it cannot access the subclass methods.

            // BusinessAccount account6 = (BusinessAccount)account3; //Even if account3 is of type Account, it is receiving SavingAccount as an object, so downcasting it is not possible, because the two classes are not related. It's like they're siblings, and a downcasting can only happen between the child class and the parent class.

            if (account3 is BusinessAccount) //This syntax is cheking if the account3 is an instance of BusinessAccount, we already know that it isn't true so it will not enter in this if.
            {
                //BusinessAccount account6 = (BusinessAccount)account3;
                BusinessAccount account6 = account3 as BusinessAccount;
                account6.Loan(100.0);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingAccount) //We know that account3 is an instance of SavingAccount, so it will enter in this if.
            {
                //SavingAccount account6 = (SavingAccount)account3;
                SavingAccount account6 = account3 as SavingAccount;
                account6.UpdateBalance();
                Console.WriteLine("Update!"); 
            }

        }
    }
}