using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class OrderDetails
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }

        public OrderDetails(string goodsName, int goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }
    }
}
