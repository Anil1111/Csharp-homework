using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace program1
{
    [Serializable]
    public class OrderService
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

            Order order = new Order(orderNum, orderName);

            order.AddGoods();

            orders.Add(order);
        }

        public List<Order> GetOrderWithNum(string num)
        {
            var query = from item in orders
                        where item.OrderNumber.Equals(num)
                        select item;
            return query.ToList();
        }
        public void DelOrderWithNum(string num)
        {
            List<Order> orderList = GetOrderWithNum(num);
            if (orderList != null)
            {
                foreach (Order order in orderList)
                {
                    orders.Remove(order);
                }
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("无匹配项！");
            }
        }

        public List<Order> GetOrderWithName(string name)
        {
            var query = from item in orders
                        where item.OrderCustomer.Equals(name)
                        select item;
            return query.ToList();
        }
        public void DelOrderWithName(string name)
        {
            List<Order> orderList = GetOrderWithName(name);
            if (orderList != null)
            {
                foreach (Order order in orderList)
                {
                    orders.Remove(order);
                }
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("无匹配项！");
            }
        }

        public List<Order> GetOrderWithPri(int price)
        {
            var query = from item in orders
                        where item.GetTotalPrice() >= price
                        select item;
            return query.ToList();
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

        public void SerOrder()
        {
            Order order;
            List<Order> orderList;
            Console.WriteLine("查询订单");
            Console.WriteLine("1.根据订单号查询    2.根据客户名查询    3.订单金额大于1万元的订单");
            Console.WriteLine("请输入数字项：");
            int menuNum = int.Parse(Console.ReadLine());
            if ((menuNum != 1) && (menuNum != 2) && (menuNum != 3))
            {
                Console.WriteLine("输入错误！");
            }
            switch (menuNum)
            {
                case 1:
                    Console.WriteLine("请输入订单号：");
                    string orderNum = Console.ReadLine();
                    orderList = GetOrderWithNum(orderNum);
                    if (orderList.Count() == 0)
                    {
                        Console.WriteLine("该订单不存在！");
                    }
                    else if (orderList.Count() != 1)
                    {
                        Console.WriteLine("存在多个订单！");
                    }
                    else
                    {
                        order = orderList[0];
                        order.ShowOrder();
                    }
                    break;
                case 2:
                    Console.WriteLine("请输入客户名：");
                    string orderCus = Console.ReadLine();
                    orderList = GetOrderWithName(orderCus);
                    if (orderList.Count() == 0)
                    {
                        Console.WriteLine("该订单不存在！");
                    }
                    else if (orderList.Count() != 1)
                    {
                        Console.WriteLine("存在多个订单！");
                    }
                    else
                    {
                        order = orderList[0];
                        order.ShowOrder();
                    }
                    break;
                case 3:
                    orderList = GetOrderWithPri(10000);
                    foreach (Order item in orderList)
                    {
                        item.ShowOrder();
                    }
                    break;
            }
        }

        public void ModOrder()
        {
            Console.WriteLine("修改订单");
            Console.WriteLine("请输入订单号：");
            string orderNum = Console.ReadLine();
            List<Order> orderList = GetOrderWithNum(orderNum);
            if (orderList.Count() == 0)
            {
                Console.WriteLine("该订单不存在！");
                return;
            }
            else if (orderList.Count() != 1)
            {
                Console.WriteLine("存在多个订单！");
            }
            else
            {
                Order order = orderList[0];
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
        }

        public void ViewOrder()
        {
            foreach (Order ord in orders)
            {
                ord.ShowOrder();
            }
        }

        public void Export(string path)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = path;

            FileStream fs = new FileStream(xmlFileName, FileMode.Create);//输出到文件
            xmlser.Serialize(fs, orders);
            fs.Close();

            StringWriter sw = new StringWriter();//输出到控制台
            xmlser.Serialize(sw, this.orders);
            sw.Close();

            Console.Write(sw.ToString());
        }

        public List<Order> Import(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            List<Order> orderList = (List<Order>)xmlser.Deserialize(file);
            file.Close();

            return orderList;
        }
    }
}
