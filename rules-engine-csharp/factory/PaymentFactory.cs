using rules_engine_csharp.models;
using rules_engine_csharp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rules_engine_csharp.implementations;

namespace rules_engine_csharp.factory
{
    internal class PaymentFactory
    {     
        public static Object create(Payment payment) {

            switch (payment.type)
            {
                case enums.Type.PHYSICAL_PRODUCT:
                    Console.WriteLine("---CREATION OF PHYSICAL_PRODUCT PAYMENT TYPE---");
                    return new PhysicalRulesImpl();

                case enums.Type.MEMBERSHIP_ACTIVATION:
                case enums.Type.MEMBERSHIP_UPGRADE:
                    Console.WriteLine("---CREATION OF MEMBERSHIP ACTIVATION/UPGRADE PAYMENT TYPE---");
                    return new MembershipRulesImpl();

                default:
                    Console.WriteLine("TYPE CREATED. NOTHING TO RETURN!");
                    return null;
            }


        }
    }
}
