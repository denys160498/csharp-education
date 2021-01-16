using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Events
{
    class Account
    {
        public delegate void AccountHandler(object sender, AccountHandlerEventArgs e);
        public event AccountHandler Notify;

        protected double balance;
        public double Balance
        { get { return balance; } }

        public Account(double sum)
        {
            balance = sum;
        }

        public void Put(double sum)
        {
            balance += sum;
            Notify?.Invoke(this, new AccountHandlerEventArgs("Successfully toped up!", sum));
        }

        public void Withdraw(double sum)
        {
            if (balance - sum < 0)
            {
                Notify?.Invoke(this, new AccountHandlerEventArgs("You don`t have enough money for withdrawing", sum));
            }
            else
            {
                balance -= sum;
                Notify?.Invoke(this, new AccountHandlerEventArgs("Money have been successfully withdrawed!", sum));
            }
        }
    }
}
