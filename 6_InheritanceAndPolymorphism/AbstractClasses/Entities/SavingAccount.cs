namespace OverlapVirtualOverrideBase.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void WithDraw(double amount) //Using the override method we are overriding a superclass method with specifications for the subclass. Note that by default, methods are non-virtual and you cannot override a non-virtual method. So we need to implement the word 'virtual' in the method we want to override. By using the word 'sealed' we are saying that this method cannot be override in a more specific class.
        {
            base.WithDraw(amount);
            Balance -= 2.0; //Using the word 'base' we are using the WithDraw method as it is in the superclass declaration and adding something else to it, in this case taking 2.0 more in any withdrawal action.
        }


    }
}