using Heranca01.Entities;

namespace Heranca01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001,"Alex",500.00);
            Account acc2 = new SavingsAccount(1001, "Anna", 500.00, 0.01); // Upcasting

            acc1.withdraw(10.0);
            acc2.withdraw(10.00);

            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);
        }
    }
}
