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
    public partial class Form2 : Form
    {
        Order result = null;

        public Form2()
        {
            InitializeComponent();
        }

        public Order getResult()
        {
            return result;
        }

        private void goodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        public Form2(Order order) : this()
        {
            orderBindingSource.DataSource = order;
        }




        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 1)
        //    {
        //        if (dataGridView1.CurrentCell.Value != null)
        //        {
        //            comboBox2.Text = dataGridView1.CurrentCell.Value.ToString();  //对combobox赋值 
        //        }

        //        Rectangle R = dataGridView1.GetCellDisplayRectangle(
        //                            dataGridView1.CurrentCell.ColumnIndex,
        //                            dataGridView1.CurrentCell.RowIndex, false);

        //        comboBox2.Location = new Point(dataGridView1.Location.X + R.X,
        //            dataGridView1.Location.Y + R.Y);

        //        comboBox2.Width = R.Width;
        //        comboBox2.Height = R.Height;
        //        comboBox2.Visible = true;
        //    }
        //    else
        //    {
        //        comboBox2.Visible = false;
        //    }

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (detailsBindingSource.Current == null)
        //    {
        //        detailsBindingSource.Add(new OrderDetail());
        //    }
        //    ((OrderDetail)detailsBindingSource.Current).Goods = (Goods)comboBox2.SelectedItem;
        //}



        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ((Order)orderBindingSource.Current).Customer = (Customer)comboBox1.SelectedItem;
        //}

        //private void FormEdit_Load(object sender, EventArgs e)
        //{
        //    comboBox1.SelectedItem =
        //        ((Order)orderBindingSource.Current).Customer;
        //}




        private void button1_Click_1(object sender, EventArgs e)
        {
            result = (Order)orderBindingSource.Current;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
