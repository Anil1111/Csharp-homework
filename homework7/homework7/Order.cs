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

        public string OrderNumber { get; set; }
        public string OrderCustomer { get; set; }
        public string OrderGoods { get; set; }
        public int OrderPrice { get; set; }

        public Order()
        {

        }

        public Order(string orderNumber, string orderCustomer)
        {
            OrderNumber = orderNumber;
            OrderCustomer = orderCustomer;
            OrderGoods = "";
            OrderPrice = 0;
        }

        public void AddGoods(OrderDetails goods)
        {
            goodsList.Add(goods);
            OrderGoods = OrderGoods + goods.GoodsName + "   ";
            OrderPrice = OrderPrice + goods.GoodsPrice;
        }
    }
}
