using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            OrderDetails goods1 = new OrderDetails("商品1", 100);
            OrderDetails goods2 = new OrderDetails("商品2", 200);
            OrderDetails goods3 = new OrderDetails("商品3", 300);
            OrderDetails goods4 = new OrderDetails("商品4", 400);
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
                Console.WriteLine("菜单：  1.添加订单   2.删除订单  3.修改订单  4.查询订单 5.退出");
                Console.WriteLine("请输入数字项：");
                int menuNum = int.Parse(Console.ReadLine());
                if ((menuNum != 1) && (menuNum != 2) && (menuNum != 3) && (menuNum != 4))
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
                        orderService.ModOrder();
                        break;
                    case 4:
                        orderService.ViewOrder();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }


        }
    }
}
