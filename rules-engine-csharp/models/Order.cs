using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.models
{
    internal class Order
    {
       
        public int Id { get; set; }
        List<Product> products { get; set; }

        public Order(int id, List<Product> products)
        {
            Id = id;
            this.products = products;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
