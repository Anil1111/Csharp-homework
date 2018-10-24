using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            OrderDetails goods1 = new OrderDetails("商品1", 3000);
            OrderDetails goods2 = new OrderDetails("商品2", 6000);
            OrderDetails goods3 = new OrderDetails("商品3", 9000);
            OrderDetails goods4 = new OrderDetails("商品4", 12000);
            Order order1 = new Order("0001", "同学1");
            order1.AddGoods(goods1);//将商品加入订单中
            order1.AddGoods(goods2);
            Order order2 = new Order("0002", "同学2");
            order2.AddGoods(goods3);//将商品加入订单中
            order2.AddGoods(goods4);

            orderService.AddOrder(order1);//将订单加入list中
            orderService.AddOrder(order2);
            Console.WriteLine("现有订单：");
            orderService.ViewOrder();

            while (true)
            {
                Console.WriteLine("菜单：  1.添加订单   2.删除订单   3.查询订单   4.修改订单   5.查看订单   " +
                    "6.序列化订单   7.反序列化并重载订单    8.退出");
                Console.WriteLine("请输入数字项：");
                int menuNum = int.Parse(Console.ReadLine());
                if ((menuNum != 1) && (menuNum != 2) && (menuNum != 3) && (menuNum != 4) && (menuNum != 5) && (menuNum != 6) && (menuNum != 7) && (menuNum != 8))
                {
                    Console.WriteLine("输入错误！");
                }
                switch (menuNum)
                {
                    case 1:
                        orderService.AddOrder();
                        break;
                    case 2:
                        orderService.DelOrder();
                        break;
                    case 3:
                        orderService.SerOrder();
                        break;
                    case 4:
                        orderService.ModOrder();
                        break;
                    case 5:
                        orderService.ViewOrder();
                        break;
                    case 6:
                        try
                        {
                            orderService.Export("s.xml");
                            //orderService.Export(@"D:\orderList.xml");
                            Console.WriteLine("XML序列化文件完成");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 7:
                        try
                        {
                            List<Order> orderList = orderService.Import("s.xml");
                            orderService = new OrderService();//orderService.Import("s.xml");
                            foreach (Order item in orderList)
                            {
                                orderService.AddOrder(item);
                            }
                            orderService.ViewOrder();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
