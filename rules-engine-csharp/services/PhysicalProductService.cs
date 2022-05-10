using rules_engine_csharp.interfaces;
using rules_engine_csharp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.services
{
    internal class PhysicalProductService
    {

        private IPhysicalRules physicalRules;

        public PhysicalProductService(IPhysicalRules physicalRules)
        {
            this.physicalRules = physicalRules;
        }


        public bool executePhysicalRules(Payment payment)
        {
            Console.WriteLine("Executing rules for physical");
            this.physicalRules.packingSlipForShipping(payment);
            this.physicalRules.giveCommissionPaymentToAgent(payment);

            return true;
        }

       
        public double calculateTotal(Payment payment)
        {
            double total = this.physicalRules.calculateTotals(payment);
            return total;
        }

    }
}
