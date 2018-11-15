using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace homework7
{
    [Serializable]
    public class OrderService
    {
        public List<Order> OrdersList;

        public OrderService()
        {
            OrdersList = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            OrdersList.Add(order);
        }

        public void DelOrder(Order order)
        {
            OrdersList.Remove(order);
        }

        public void Export(string path)//将List存到文件中
        {
            string xmlFileName = path;

            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            FileStream fs = new FileStream(xmlFileName, FileMode.Create);
            xmlser.Serialize(fs, OrdersList);
            fs.Close();
        }

        public List<Order> Import(string path)//加载List
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            List<Order> orderList = (List<Order>)xmlser.Deserialize(file);
            file.Close();

            return orderList;
        }
    }
}
