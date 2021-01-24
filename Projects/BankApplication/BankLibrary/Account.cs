using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        protected internal event AccountStateHandler Withdrawed;
        protected internal event AccountStateHandler Added;
        protected internal event AccountStateHandler Opened;
        protected internal event AccountStateHandler Closed;
        protected internal event AccountStateHandler Calculated;

        static int counter;
        protected int _days = 0;

        public decimal Sum { get; private set; }
        public int Percentage { get; private set; }
        public int Id { get; private set; }

        public Account(decimal sum, int percentage)
        {
            Sum = sum;
            Percentage = percentage;
            Id = ++counter;
        }

        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (e != null)
            {
                handler?.Invoke(this, e);
            }
        }

        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }

        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }

        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }

        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }

        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs($"Account toped up by {sum}", sum));
        }

        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;

            if (Sum < sum)
            {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs($"{sum} withdrawed from account #{Id}", sum));
            }
            else
            {
                OnWithdrawed(new AccountEventArgs($"Account #{Id} does not contain enough money", sum));
            }

            return result;
        }

        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"New Account with id #{Id} has been opened!", Sum));
        }

        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs($"Account #{Id} has been closed. Sum: {Sum}", Sum));
        }

        protected internal void IncrementDays()
        {
            _days++;
        }

        protected internal virtual void Calculate()
        {
            decimal increment = Sum * Percentage / 100;
            Sum += increment;
            OnCalculated(new AccountEventArgs($"Interest accrued on the account #{Id} in amount: {increment}", increment));
        }
    }
}
