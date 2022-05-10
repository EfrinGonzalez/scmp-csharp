using rules_engine_csharp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.interfaces
{
    internal interface IMembershipRules
    {
        bool activateMembership(Payment payment);
        bool upgradeMembership(Payment payment);
    }
}
