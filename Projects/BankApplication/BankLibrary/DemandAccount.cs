using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class DemandAccount: Account
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }

        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"New Demand Account has been opened! Account Id: {this.Id}", this.Sum));
        }
    }
}
