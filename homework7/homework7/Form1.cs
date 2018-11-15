using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;


namespace homework7
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();

            Order order1 = new Order("20181115001", "Lee", "18627184110");
            Order order2 = new Order("20181115002", "Chen", "18772529577");

            OrderDetails goodsList1 = new OrderDetails("water", 1, 1);
            OrderDetails goodsList2 = new OrderDetails("pen", 2, 2);
            OrderDetails goodsList3 = new OrderDetails("bread", 3, 3);
            OrderDetails goodsList4 = new OrderDetails("milk", 4, 4);

            order1.AddDetail(goodsList1);
            order1.AddDetail(goodsList2);
            order2.AddDetail(goodsList3);
            order2.AddDetail(goodsList4);

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
                        orderService.OrdersList.Where(order => order.Customer == KeyWord);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(new Order());
            form2.ShowDialog();
            Order newOrder = form2.getResult();
            if (newOrder != null)
            {
                bool idOK, phoneOK;
                idOK = false;
                phoneOK = false;

                string number = "20[0-9]{2}0[1-9][0-2][0-9][0-9]{3}";
                Regex rx1 = new Regex(number);
                string number2 = "20[0-9]{2}1[0-2][0-2][0-9][0-9]{3}";
                Regex rx2 = new Regex(number2);
                string number3 = "20[0-9]{2}0[1-9]3[0-1][0-9]{3}";
                Regex rx3 = new Regex(number3);
                string number4 = "20[0-9]{2}1[0-2]3[0-1][0-9]{3}";
                Regex rx4 = new Regex(number4);
                Match m1 = rx1.Match(newOrder.Number);
                Match m2 = rx2.Match(newOrder.Number);
                Match m3 = rx3.Match(newOrder.Number);
                Match m4 = rx4.Match(newOrder.Number);
                idOK = m1.Success || m2.Success || m3.Success || m4.Success;

                Regex phoneRx = new Regex("[0-9]{11}");
                phoneOK = phoneRx.IsMatch(newOrder.Phone);

                if (idOK)
                {
                    if (phoneOK)
                    {
                        orderService.AddOrder(newOrder);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = orderService.OrdersList;
                        orderBindingSource1.DataSource = bs;
                    }
                    else
                    {
                        MessageBox.Show("用户手机格式不正确！");
                    }
                }
                else
                {
                    MessageBox.Show("订单号格式不正确！");
                }
            }

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Order order = (Order)orderBindingSource1.Current;
            if (order != null)
            {
                orderService.DelOrder(order);

                BindingSource bs = new BindingSource();
                bs.DataSource = orderService.OrdersList;
                orderBindingSource1.DataSource = bs;
            }
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2((Order)orderBindingSource1.Current);
            form2.ShowDialog();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.OrdersList = orderService.Import(fileName);

                BindingSource bs = new BindingSource();
                bs.DataSource = orderService.OrdersList;
                orderBindingSource1.DataSource = bs;
            }
        }

        private void ExHtmlButton_Click(object sender, EventArgs e)
        {
            orderService.Export("order.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load(@"order.xml");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslCompiledTransform xt = new XslCompiledTransform();
            xt.Load(@"..\..\x.xslt");

            FileStream outfile = File.OpenWrite("s.html");

            XmlTextWriter writer = new XmlTextWriter(outfile, System.Text.Encoding.UTF8);

            xt.Transform(nav, null, writer);
            outfile.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}