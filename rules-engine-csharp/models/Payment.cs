using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rules_engine_csharp.models
{
    internal class Payment
    {

        public int id { get; set; }
        public enums.Type type { get; set; }
        public Order order { get; set; }

        public Payment(int id, enums.Type type, Order order)
        {
            this.id = id;
            this.type = type;
            this.order = order;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
