using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();

            Order order1 = new Order("0001", "同学1");
            Order order2 = new Order("0002", "同学2");
            OrderDetails goods1 = new OrderDetails("商品1", 3000);
            OrderDetails goods2 = new OrderDetails("商品2", 6000);
            OrderDetails goods3 = new OrderDetails("商品3", 9000);
            OrderDetails goods4 = new OrderDetails("商品4", 12000);

            order1.AddGoods(goods1);
            order1.AddGoods(goods2);
            order2.AddGoods(goods3);
            order2.AddGoods(goods4);

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            orderService.Export("temp.xml");

            //绑定列表
            orderBindingSource1.DataSource = orderService.OrdersList;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyWord == "")
                {
                    orderBindingSource1.DataSource =
                        orderService.OrdersList;
                }
                else
                {
                    orderBindingSource1.DataSource =
                        orderService.OrdersList.Where(order => order.OrderCustomer == KeyWord);
                }
            }
            catch (Exception)
            {
                orderBindingSource1.DataSource =
                    orderService.OrdersList;
                MessageBox.Show("未找到该客户");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}