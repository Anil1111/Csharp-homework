using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class OrderService
    {
        List<Order> orders = new List<Order>();      

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void AddOrder()
        {
            Console.WriteLine("添加订单");
            Console.WriteLine("请输入订单号：");
            string orderNum = Console.ReadLine();
            Console.WriteLine("请输入客户名称：");
            string orderName = Console.ReadLine();

            Order order = new Order("orderNum", "orderName");

            order.AddGoods();

            orders.Add(order);
        }


        private Order GetOrderWithNum(string num)
        {
            foreach (Order ord in orders)
            {
                if (ord.OrderNumber == num)//有多个匹配项暂未考虑
                {
                    return ord;
                }
            }
            return null;
        }
        public void DelOrderWithNum(string num)
        {
            Order order = GetOrderWithNum(num);
            if (order != null)
            {
                orders.Remove(order);
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("无匹配项！");
            }
        }

        private Order GetOrderWithName(string name)
        {
            foreach (Order ord in orders)
            {
                if (ord.OrderCustomer == name)//有多个匹配项暂未考虑
                {
                    return ord;
                }
            }
            return null;
        }
        public void DelOrderWithName(string name)
        {
            Order order = GetOrderWithName(name);
            if (order != null)
            {
                orders.Remove(order);
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("无匹配项！");
            }
        }

        public void DelOrder()
        {
            Console.WriteLine("删除订单");
            Console.WriteLine("1.根据订单号删除    2.根据客户名称删除");
            Console.WriteLine("请输入数字项：");
            int menuNum = int.Parse(Console.ReadLine());
            if ((menuNum != 1) && (menuNum != 2))
            {
                Console.WriteLine("输入错误！");
            }
            switch (menuNum)
            {
                case 1:
                    Console.WriteLine("输入订单号");
                    string orderNum = Console.ReadLine();
                    DelOrderWithNum(orderNum);
                    break;
                case 2:
                    Console.WriteLine("输入客户名称");
                    string orderCustomer = Console.ReadLine();
                    DelOrderWithName(orderCustomer);
                    break;
            }
        }

        public void ModOrder()
        {
            Console.WriteLine("修改订单");
            Console.WriteLine("请输入订单号：");
            string orderNum = Console.ReadLine();
            Order order = GetOrderWithNum(orderNum);
            if(order == null)
            {
                Console.WriteLine("该订单不存在！");
                return;
            }

            Console.WriteLine("1.修改订单号    2.修改客户名称    3.修改商品");
            Console.WriteLine("请输入数字项：");
            int menuNum = int.Parse(Console.ReadLine());
            if ((menuNum != 1) && (menuNum != 2) && (menuNum != 3))
            {
                Console.WriteLine("输入错误！");
            }
            switch (menuNum)
            {
                case 1:
                    Console.WriteLine("输入新的订单号");
                    string newOrderNum = Console.ReadLine();
                    order.OrderNumber = newOrderNum;
                    break;
                case 2:
                    Console.WriteLine("输入新的客户名称");
                    string newOrderCustomer = Console.ReadLine();
                    order.OrderCustomer = newOrderCustomer;
                    break;
                case 3:
                    Console.WriteLine("修改商品");
                    Console.WriteLine("1.添加商品    2.删除商品");
                    Console.WriteLine("请输入数字项：");
                    int menuNum2 = int.Parse(Console.ReadLine());
                    if ((menuNum2 != 1) && (menuNum2 != 2) && (menuNum2 != 3))
                    {
                        Console.WriteLine("输入错误！");
                    }
                    switch (menuNum2)
                    {
                        case 1:
                            order.AddGoods();
                            break;
                        case 2:
                            order.DelGoods();
                            break;
                    }
                    break;
            }
        }

        public void ViewOrder()
        {
            foreach (Order ord in orders)
            {
                ord.ShowOrder();
            }
        }
    }
}
