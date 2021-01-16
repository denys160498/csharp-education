using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Events
{
    class PersonalAccount: Account
    {
        public override string Type
        { get { return "Personal Account"; } }

        public PersonalAccount(double sum) : base(sum)
        { 
        }
    }
}
