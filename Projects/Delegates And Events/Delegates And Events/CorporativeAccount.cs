using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Events
{
    class CorporativeAccount: Account
    {
        public override string Type
        { get { return "Corporative Account"; } }

        public CorporativeAccount(double sum) : base(sum)
        {
        }
    }
}
