using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.interfaces
{
    internal interface IEmailRules
    {
        bool notifyOwnerViaEmail(String notificationTitle, String NotificationDescription);

    }
}
