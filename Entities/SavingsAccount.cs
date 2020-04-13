namespace Heranca01.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
        }

        sealed public override void withdraw(double amount)
        {
            base.withdraw(amount);
            Balance -= 2;
        } 
    }
}
