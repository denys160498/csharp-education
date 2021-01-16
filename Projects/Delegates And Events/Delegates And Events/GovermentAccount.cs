using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Events
{
    class GovermentAccount: Account
    {
        public override string Type
        { get { return "Goverment Account"; } }

        public GovermentAccount(double sum) : base(sum)
        {
        }
    }
}
