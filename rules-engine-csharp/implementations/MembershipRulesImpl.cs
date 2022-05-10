using rules_engine_csharp.interfaces;
using rules_engine_csharp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.implementations
{
    internal class MembershipRulesImpl : IMembershipRules
    {
        public bool activateMembership(Payment payment)
        {
            Console.WriteLine("Membership activated.");
            return true;
        }

        public bool upgradeMembership(Payment payment)
        {
            Console.WriteLine("Membership upgraded.");
            return true;
        }
    }
}
