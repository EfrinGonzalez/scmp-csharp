using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rules_engine_csharp.models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public Product(int id, string name, string description, double price, int amount)
        {
            Id = id;
            Name = name;
            Description = description;
            this.price = price;
            this.amount = amount;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
