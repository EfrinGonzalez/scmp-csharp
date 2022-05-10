using rules_engine_csharp.interfaces;
using rules_engine_csharp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.services
{
    internal class MembershipService
    {
        private IMembershipRules membershipDistributor;
        private IEmailRules notificator;

        public MembershipService(IMembershipRules membershipDistributor, IEmailRules notificator)
        {
            this.membershipDistributor = membershipDistributor;
            this.notificator = notificator;
        }
        public bool executeCreationRules(Payment payment)
        {
            Console.WriteLine("Executing rules for Activation of Membership");
            this.membershipDistributor.activateMembership(payment);
            this.notificator.notifyOwnerViaEmail("Membership activation", "You are notified that your membership is active from now on.");

            return true;
        }

        public bool executeUpgradeRules(Payment payment)
        {
            Console.WriteLine("Executing rules for Upgrading of Membership");
            this.membershipDistributor.upgradeMembership(payment);
            this.notificator.notifyOwnerViaEmail("Membership upgrade", "You are notified that your upgraded is active from now on.");

            return true;
        }
    }
}
