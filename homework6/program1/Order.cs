using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class Order
    {
        public List<OrderDetails> goodsList = new List<OrderDetails>();

        public string OrderNumber { get; set; }
        public string OrderCustomer { get; set; }

        public Order()
        {
        }

        public Order(string orderNumber, string orderCustomer)
        {
            OrderNumber = orderNumber;
            OrderCustomer = orderCustomer;
        }


        public void AddGoods(OrderDetails goods)
        {
            goodsList.Add(goods);
        }

        public void AddGoods()
        {
            Console.WriteLine("请输入添加商品个数");
            int addGoodsNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < addGoodsNum; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "件商品名称：");
                string tempName = Console.ReadLine();
                Console.WriteLine("请输入第" + (i + 1) + "件商品价格：");
                int tempPrice = int.Parse(Console.ReadLine());
                OrderDetails tempGoods = new OrderDetails(tempName, tempPrice);
                this.AddGoods(tempGoods);
            }
        }

        public void DelGoods()
        {
            Console.WriteLine("请输入删除商品个数");
            int addGoodsNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < addGoodsNum; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "件商品名称：");
                string tempName = Console.ReadLine();
                foreach (OrderDetails goods in this.goodsList)
                {
                    if (goods.GoodsName == tempName)//有多个匹配项暂未考虑
                    {
                        this.goodsList.Remove(goods);
                        Console.WriteLine("删除成功");
                    }
                }
                Console.WriteLine("未找到匹配项");
            }
        }

        public string ShowGoods()
        {
            string allGoods;
            if (goodsList[0] != null)
            {
                allGoods = goodsList[0].GoodsName;
            }
            else
            {
                allGoods = "暂无商品";
                return allGoods;
            }
            for (int i = 1; i < goodsList.Count; i++)
            {
                allGoods = allGoods + ", " + goodsList[i].GoodsName;
            }
            allGoods = allGoods + "。";
            return allGoods;
        }

        public int GetTotalPrice()
        {
            int price = 0;
            foreach (OrderDetails item in goodsList)
            {
                price += item.GoodsPrice;
            }
            return price;
        }

        public void ShowOrder()
        {
            Console.WriteLine(OrderNumber + "  " + OrderCustomer + "   " + "商品：" + ShowGoods());
        }
    }
}
