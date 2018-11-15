using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class Order
    {
        public List<OrderDetails> goodsList = new List<OrderDetails>();

        public string Number { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }

        public string AllGoods { get; set; }
        public double AllPrice { get; set; }

        public Order() { }

        public Order(string number, string customer, string phone)
        {
            Number = number;
            Customer = customer;
            Phone = phone;
            AllGoods = "";
            AllPrice = 0;
            foreach (OrderDetails item in goodsList)
            {
                AllGoods = AllGoods + item.ToString() + "   ";
                AllPrice = AllPrice + item.Price * item.Quantity;
            }
        }

        public void AddDetail(OrderDetails detail)
        {
            goodsList.Add(detail);
            AllGoods = AllGoods + detail.ToString() + "   ";
            AllPrice = AllPrice + detail.Price * detail.Quantity;
        }
    }
}
