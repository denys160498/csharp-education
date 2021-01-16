using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Events
{
    class AccountHandlerEventArgs
    {
        public double Sum { get; }
        public string Message { get; }

        public AccountHandlerEventArgs(string mes, double sum)
        {
            Sum = sum;
            Message = mes;
        }

    }
}
