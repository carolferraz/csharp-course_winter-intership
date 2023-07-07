namespace OverlapVirtualOverrideBase.Entities
{
    class BusinessAccount : Account //Using the ":" syntax we are saying that the BusinessAccount extends the class Account. Then we can access his props and methods.
    {
        public double LoanLimit { get; set; }


        public BusinessAccount()
        {}

        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance) //Using the ": base()" syntax we can choose the parameters of a constructor and reuse it without having to repeat code inside the class we are creating. 
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if(amount < LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}