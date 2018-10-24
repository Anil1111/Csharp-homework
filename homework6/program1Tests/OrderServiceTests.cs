using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order("001", "Lee June");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Assert.IsTrue(orderService != null);
        }

        [TestMethod()]
        public void AddOrderTest1()
        {
            Order order = new Order("001", "Lee June");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Assert.IsTrue(orderService != null);
        }

        [TestMethod()]
        public void GetOrderWithNumTest()
        {
            Order order = new Order("001", "Lee June");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            List<Order> orderTest = orderService.GetOrderWithNum("001");
            Assert.IsTrue(orderTest[0].OrderCustomer == "Lee June");
        }

        [TestMethod()]
        public void DelOrderWithNumTest()
        {
            Order order1 = new Order("1234", "Lee June");
            Order order2 = new Order("5678", "cst");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            orderService.DelOrderWithNum("1234");
            Assert.IsTrue(orderService.GetOrderWithNum("1234") != null);
        }

        [TestMethod()]
        public void GetOrderWithNameTest()
        {
            Order order1 = new Order("1234", "Lee June");
            Order order2 = new Order("5678", "cst");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            List<Order> orderTest = orderService.GetOrderWithName("Lee June");
            Assert.IsTrue(orderTest[0].OrderNumber == "1234");
        }

        [TestMethod()]
        public void DelOrderWithNameTest()
        {
            Order order1 = new Order("1234", "Lee June");
            Order order2 = new Order("5678", "cst");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            orderService.DelOrderWithName("Lee June");
            Assert.IsTrue(orderService.GetOrderWithNum("1234") != null);
        }

        [TestMethod()]
        public void GetOrderWithPriTest()
        {
            OrderService orderService = new OrderService();

            OrderDetails goods1 = new OrderDetails("商品1", 3000);
            Order order1 = new Order("1234", "Lee June");
            order1.AddGoods(goods1);
            orderService.AddOrder(order1);

            orderService.GetOrderWithPri(3000);
            Assert.IsTrue(orderService.GetOrderWithNum("1234") != null);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Order order1 = new Order("1234", "Lee June");
            Order order2 = new Order("5678", "cst");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export(@"temp.xml");
            List<Order> orderTest = orderService.Import(@"temp.xml");

            Assert.IsTrue(orderTest[0].OrderCustomer == "Lee June");
        }

        [TestMethod()]
        public void ImportTest()
        {
            Order order1 = new Order("1234", "Lee June");
            Order order2 = new Order("5678", "cst");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export(@"temp.xml");
            List<Order> orderTest = orderService.Import(@"temp.xml");

            Assert.IsTrue(orderTest[0].OrderCustomer == "Lee June");
        }
    }
}