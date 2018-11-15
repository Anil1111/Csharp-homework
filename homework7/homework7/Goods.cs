using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class Goods
    {
        private double price;

        public string Name { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }

        public Goods() { }
        
        public Goods(string name, double value)
        {
            Name = name;
            Price = value;
        }
    }
}
