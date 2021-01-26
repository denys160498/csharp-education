using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class BankEnumerator<T> : IEnumerator<T> where T : Account
    {
        T[] accounts;
        int position = -1;

        public BankEnumerator(T[] accounts)
        {
            this.accounts = accounts;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position > accounts.Length)
                {
                    throw new InvalidOperationException();
                }
                return accounts[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < accounts.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}
