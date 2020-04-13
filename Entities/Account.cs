﻿namespace Heranca01.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void withdraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
    }
}
