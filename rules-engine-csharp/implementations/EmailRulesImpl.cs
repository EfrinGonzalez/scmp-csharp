using rules_engine_csharp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.implementations
{
    internal class EmailRulesImpl : IEmailRules
    {
        public bool notifyOwnerViaEmail(string notificationTitle, string NotificationDescription)
        {
           Console.WriteLine(notificationTitle + ":" + NotificationDescription);
            return true;
        }
    }
}
