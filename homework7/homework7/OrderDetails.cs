using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class OrderDetails
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderDetails() { }

        public OrderDetails(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "*" + Quantity;
        }
    }
}
