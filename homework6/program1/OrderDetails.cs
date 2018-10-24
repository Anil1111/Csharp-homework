using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class OrderDetails
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }

        public OrderDetails()
        {

        }

        public OrderDetails(string goodsName, int goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }
    }
}
