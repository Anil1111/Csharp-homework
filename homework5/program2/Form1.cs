using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private Pen pen = new Pen(Color.Pink, (float)1);
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 0.5;

        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = leng * Math.Cos(th) * k + x0;
            double y2 = leng * Math.Sin(th) * k + y0;

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                th1 = Convert.ToDouble(textBox1.Text) * Math.PI / 180;
                th2 = Convert.ToDouble(textBox2.Text) * Math.PI / 180;
                per1 = Convert.ToDouble(textBox3.Text);
                per2 = Convert.ToDouble(textBox4.Text);
                k = Convert.ToDouble(textBox5.Text);
                if (graphics == null) graphics = this.CreateGraphics();
                DrawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
