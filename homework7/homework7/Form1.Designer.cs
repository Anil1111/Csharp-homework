namespace homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExHtmlButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExHtmlButton);
            this.panel1.Controls.Add(this.ImportButton);
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Controls.Add(this.ModButton);
            this.panel1.Controls.Add(this.DelButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 158);
            this.panel1.TabIndex = 0;
            // 
            // ExHtmlButton
            // 
            this.ExHtmlButton.Location = new System.Drawing.Point(731, 31);
            this.ExHtmlButton.Name = "ExHtmlButton";
            this.ExHtmlButton.Size = new System.Drawing.Size(123, 37);
            this.ExHtmlButton.TabIndex = 7;
            this.ExHtmlButton.Text = "导出为html";
            this.ExHtmlButton.UseVisualStyleBackColor = true;
            this.ExHtmlButton.Click += new System.EventHandler(this.ExHtmlButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(590, 31);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(100, 37);
            this.ImportButton.TabIndex = 6;
            this.ImportButton.Text = "导入订单";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(447, 31);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(100, 37);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "导出订单";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(311, 31);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(100, 37);
            this.ModButton.TabIndex = 4;
            this.ModButton.Text = "修改订单";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(176, 31);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(100, 37);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "删除订单";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(40, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 37);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "添加订单";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(176, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 35);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 586);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.allGoodsDataGridViewTextBoxColumn,
            this.allPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.currentOrder);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 644);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // currentOrder
            // 
            this.currentOrder.AutoSize = true;
            this.currentOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Number", true));
            this.currentOrder.Location = new System.Drawing.Point(185, 36);
            this.currentOrder.Name = "currentOrder";
            this.currentOrder.Size = new System.Drawing.Size(0, 18);
            this.currentOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前选中订单号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(homework7.Order);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // allGoodsDataGridViewTextBoxColumn
            // 
            this.allGoodsDataGridViewTextBoxColumn.DataPropertyName = "AllGoods";
            this.allGoodsDataGridViewTextBoxColumn.HeaderText = "AllGoods";
            this.allGoodsDataGridViewTextBoxColumn.Name = "allGoodsDataGridViewTextBoxColumn";
            this.allGoodsDataGridViewTextBoxColumn.Width = 200;
            // 
            // allPriceDataGridViewTextBoxColumn
            // 
            this.allPriceDataGridViewTextBoxColumn.DataPropertyName = "AllPrice";
            this.allPriceDataGridViewTextBoxColumn.HeaderText = "AllPrice";
            this.allPriceDataGridViewTextBoxColumn.Name = "allPriceDataGridViewTextBoxColumn";
            this.allPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label currentOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ExHtmlButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

