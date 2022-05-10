using rules_engine_csharp.interfaces;
using rules_engine_csharp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.implementations
{
    internal class PhysicalRulesImpl : IPhysicalRules
    {
        public double calculateTotals(Payment payment)
        {
           Console.WriteLine("Calculating totals for the payment...");
            return 20.00;
        }

        public bool giveCommissionPaymentToAgent(Payment payment)
        {
            Console.WriteLine("Packing slip for shipping has been created...");
            return true;
        }

        public bool packingSlipForShipping(Payment payment)
        {
            Console.WriteLine("Packing slip for shipping has been created...");
            return true;
        }
    }
}
