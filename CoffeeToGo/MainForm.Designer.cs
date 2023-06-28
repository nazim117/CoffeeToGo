namespace CoffeeTogo
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new System.Windows.Forms.TabControl();
			tabPage1 = new System.Windows.Forms.TabPage();
			btnRemoveCustomer = new System.Windows.Forms.Button();
			btnLoadOrder = new System.Windows.Forms.Button();
			btnSaveOrder = new System.Windows.Forms.Button();
			btnLoadCustomer = new System.Windows.Forms.Button();
			btnSave = new System.Windows.Forms.Button();
			btnMakeOrder = new System.Windows.Forms.Button();
			btnAddCustomer = new System.Windows.Forms.Button();
			lbOrders = new System.Windows.Forms.ListBox();
			lbCustomers = new System.Windows.Forms.ListBox();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			dataGridView2 = new System.Windows.Forms.DataGridView();
			tabPage2 = new System.Windows.Forms.TabPage();
			lblVoucher = new System.Windows.Forms.Label();
			lblCustomerOrders = new System.Windows.Forms.Label();
			lblCustomerOrderPrice = new System.Windows.Forms.Label();
			btnUseVoucher = new System.Windows.Forms.Button();
			lbCustomerOrder = new System.Windows.Forms.ListBox();
			btnGiveOrder = new System.Windows.Forms.Button();
			cbbOrder = new System.Windows.Forms.ComboBox();
			cbbCustomer = new System.Windows.Forms.ComboBox();
			dataGridView3 = new System.Windows.Forms.DataGridView();
			tabPage4 = new System.Windows.Forms.TabPage();
			btnGiveTopCustomersVoucher = new System.Windows.Forms.Button();
			lbTopCustomers = new System.Windows.Forms.ListBox();
			tabPage3 = new System.Windows.Forms.TabPage();
			lblRevenue = new System.Windows.Forms.Label();
			lblSoldCoffeePerCustomer = new System.Windows.Forms.Label();
			lblCoffeeSoldPerMonth = new System.Windows.Forms.Label();
			lblTopCustomers = new System.Windows.Forms.Label();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			tabPage4.SuspendLayout();
			tabPage3.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Location = new System.Drawing.Point(-4, 3);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(664, 351);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabPage1.Controls.Add(btnRemoveCustomer);
			tabPage1.Controls.Add(btnLoadOrder);
			tabPage1.Controls.Add(btnSaveOrder);
			tabPage1.Controls.Add(btnLoadCustomer);
			tabPage1.Controls.Add(btnSave);
			tabPage1.Controls.Add(btnMakeOrder);
			tabPage1.Controls.Add(btnAddCustomer);
			tabPage1.Controls.Add(lbOrders);
			tabPage1.Controls.Add(lbCustomers);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Controls.Add(dataGridView2);
			tabPage1.Location = new System.Drawing.Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new System.Windows.Forms.Padding(3);
			tabPage1.Size = new System.Drawing.Size(656, 318);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Prepare Order";
			// 
			// btnRemoveCustomer
			// 
			btnRemoveCustomer.Location = new System.Drawing.Point(170, 195);
			btnRemoveCustomer.Name = "btnRemoveCustomer";
			btnRemoveCustomer.Size = new System.Drawing.Size(138, 29);
			btnRemoveCustomer.TabIndex = 10;
			btnRemoveCustomer.Text = "Remove Customer";
			btnRemoveCustomer.UseVisualStyleBackColor = true;
			btnRemoveCustomer.Click += btnRemoveCustomer_Click;
			// 
			// btnLoadOrder
			// 
			btnLoadOrder.Location = new System.Drawing.Point(486, 247);
			btnLoadOrder.Name = "btnLoadOrder";
			btnLoadOrder.Size = new System.Drawing.Size(94, 29);
			btnLoadOrder.TabIndex = 8;
			btnLoadOrder.Text = "Load Data";
			btnLoadOrder.UseVisualStyleBackColor = true;
			btnLoadOrder.Click += btnLoadOrder_Click;
			// 
			// btnSaveOrder
			// 
			btnSaveOrder.Location = new System.Drawing.Point(386, 247);
			btnSaveOrder.Name = "btnSaveOrder";
			btnSaveOrder.Size = new System.Drawing.Size(94, 29);
			btnSaveOrder.TabIndex = 7;
			btnSaveOrder.Text = "Save Data";
			btnSaveOrder.UseVisualStyleBackColor = true;
			btnSaveOrder.Click += btnSaveOrder_Click;
			// 
			// btnLoadCustomer
			// 
			btnLoadCustomer.Location = new System.Drawing.Point(170, 247);
			btnLoadCustomer.Name = "btnLoadCustomer";
			btnLoadCustomer.Size = new System.Drawing.Size(94, 29);
			btnLoadCustomer.TabIndex = 6;
			btnLoadCustomer.Text = "Load Data";
			btnLoadCustomer.UseVisualStyleBackColor = true;
			btnLoadCustomer.Click += btnLoadCustomer_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new System.Drawing.Point(70, 247);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(94, 29);
			btnSave.TabIndex = 5;
			btnSave.Text = "Save Data";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click_1;
			// 
			// btnMakeOrder
			// 
			btnMakeOrder.Location = new System.Drawing.Point(337, 195);
			btnMakeOrder.Name = "btnMakeOrder";
			btnMakeOrder.Size = new System.Drawing.Size(282, 29);
			btnMakeOrder.TabIndex = 4;
			btnMakeOrder.Text = "Make Order";
			btnMakeOrder.UseVisualStyleBackColor = true;
			btnMakeOrder.Click += btnMakeOrder_Click;
			// 
			// btnAddCustomer
			// 
			btnAddCustomer.Location = new System.Drawing.Point(26, 195);
			btnAddCustomer.Name = "btnAddCustomer";
			btnAddCustomer.Size = new System.Drawing.Size(138, 29);
			btnAddCustomer.TabIndex = 2;
			btnAddCustomer.Text = "Add Customer";
			btnAddCustomer.UseVisualStyleBackColor = true;
			btnAddCustomer.Click += btnAddCustomer_Click_1;
			// 
			// lbOrders
			// 
			lbOrders.FormattingEnabled = true;
			lbOrders.ItemHeight = 20;
			lbOrders.Location = new System.Drawing.Point(337, 31);
			lbOrders.Name = "lbOrders";
			lbOrders.Size = new System.Drawing.Size(282, 144);
			lbOrders.TabIndex = 1;
			lbOrders.SelectedIndexChanged += lbOrders_SelectedIndexChanged;
			// 
			// lbCustomers
			// 
			lbCustomers.FormattingEnabled = true;
			lbCustomers.ItemHeight = 20;
			lbCustomers.Location = new System.Drawing.Point(26, 31);
			lbCustomers.Name = "lbCustomers";
			lbCustomers.Size = new System.Drawing.Size(282, 144);
			lbCustomers.TabIndex = 0;
			lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(17, 11);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new System.Drawing.Size(300, 282);
			dataGridView1.TabIndex = 1;
			// 
			// dataGridView2
			// 
			dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new System.Drawing.Point(323, 11);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.RowTemplate.Height = 29;
			dataGridView2.Size = new System.Drawing.Size(310, 282);
			dataGridView2.TabIndex = 9;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabPage2.Controls.Add(lblVoucher);
			tabPage2.Controls.Add(lblCustomerOrders);
			tabPage2.Controls.Add(lblCustomerOrderPrice);
			tabPage2.Controls.Add(btnUseVoucher);
			tabPage2.Controls.Add(lbCustomerOrder);
			tabPage2.Controls.Add(btnGiveOrder);
			tabPage2.Controls.Add(cbbOrder);
			tabPage2.Controls.Add(cbbCustomer);
			tabPage2.Controls.Add(dataGridView3);
			tabPage2.Location = new System.Drawing.Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new System.Windows.Forms.Padding(3);
			tabPage2.Size = new System.Drawing.Size(656, 318);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Deliver Order";
			// 
			// lblVoucher
			// 
			lblVoucher.AutoSize = true;
			lblVoucher.BackColor = System.Drawing.Color.LightGray;
			lblVoucher.Location = new System.Drawing.Point(76, 267);
			lblVoucher.Name = "lblVoucher";
			lblVoucher.Size = new System.Drawing.Size(91, 20);
			lblVoucher.TabIndex = 8;
			lblVoucher.Text = "No vouchers";
			// 
			// lblCustomerOrders
			// 
			lblCustomerOrders.AutoSize = true;
			lblCustomerOrders.Location = new System.Drawing.Point(273, 19);
			lblCustomerOrders.Name = "lblCustomerOrders";
			lblCustomerOrders.Size = new System.Drawing.Size(159, 20);
			lblCustomerOrders.TabIndex = 7;
			lblCustomerOrders.Text = "No customers selected";
			// 
			// lblCustomerOrderPrice
			// 
			lblCustomerOrderPrice.AutoSize = true;
			lblCustomerOrderPrice.Location = new System.Drawing.Point(76, 199);
			lblCustomerOrderPrice.Name = "lblCustomerOrderPrice";
			lblCustomerOrderPrice.Size = new System.Drawing.Size(50, 20);
			lblCustomerOrderPrice.TabIndex = 6;
			lblCustomerOrderPrice.Text = "label1";
			// 
			// btnUseVoucher
			// 
			btnUseVoucher.Location = new System.Drawing.Point(439, 263);
			btnUseVoucher.Name = "btnUseVoucher";
			btnUseVoucher.Size = new System.Drawing.Size(94, 29);
			btnUseVoucher.TabIndex = 5;
			btnUseVoucher.Text = "Use voucher";
			btnUseVoucher.UseVisualStyleBackColor = true;
			btnUseVoucher.Click += btnUseVoucher_Click;
			// 
			// lbCustomerOrder
			// 
			lbCustomerOrder.FormattingEnabled = true;
			lbCustomerOrder.ItemHeight = 20;
			lbCustomerOrder.Location = new System.Drawing.Point(271, 53);
			lbCustomerOrder.Name = "lbCustomerOrder";
			lbCustomerOrder.Size = new System.Drawing.Size(273, 184);
			lbCustomerOrder.TabIndex = 3;
			lbCustomerOrder.SelectedIndexChanged += lbCustomerOrder_SelectedIndexChanged;
			// 
			// btnGiveOrder
			// 
			btnGiveOrder.Location = new System.Drawing.Point(76, 157);
			btnGiveOrder.Name = "btnGiveOrder";
			btnGiveOrder.Size = new System.Drawing.Size(151, 29);
			btnGiveOrder.TabIndex = 2;
			btnGiveOrder.Text = "Give order to customer";
			btnGiveOrder.UseVisualStyleBackColor = true;
			btnGiveOrder.Click += btnGiveOrder_Click;
			// 
			// cbbOrder
			// 
			cbbOrder.FormattingEnabled = true;
			cbbOrder.Location = new System.Drawing.Point(76, 101);
			cbbOrder.Name = "cbbOrder";
			cbbOrder.Size = new System.Drawing.Size(151, 28);
			cbbOrder.TabIndex = 1;
			// 
			// cbbCustomer
			// 
			cbbCustomer.FormattingEnabled = true;
			cbbCustomer.Location = new System.Drawing.Point(76, 53);
			cbbCustomer.Name = "cbbCustomer";
			cbbCustomer.Size = new System.Drawing.Size(151, 28);
			cbbCustomer.TabIndex = 0;
			cbbCustomer.SelectedIndexChanged += cbbCustomer_SelectedIndexChanged;
			// 
			// dataGridView3
			// 
			dataGridView3.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView3.Location = new System.Drawing.Point(67, 254);
			dataGridView3.Name = "dataGridView3";
			dataGridView3.RowHeadersWidth = 51;
			dataGridView3.RowTemplate.Height = 29;
			dataGridView3.Size = new System.Drawing.Size(477, 47);
			dataGridView3.TabIndex = 9;
			// 
			// tabPage4
			// 
			tabPage4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabPage4.Controls.Add(lblTopCustomers);
			tabPage4.Controls.Add(btnGiveTopCustomersVoucher);
			tabPage4.Controls.Add(lbTopCustomers);
			tabPage4.Location = new System.Drawing.Point(4, 29);
			tabPage4.Name = "tabPage4";
			tabPage4.Size = new System.Drawing.Size(656, 318);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Top Customers";
			// 
			// btnGiveTopCustomersVoucher
			// 
			btnGiveTopCustomersVoucher.Location = new System.Drawing.Point(377, 147);
			btnGiveTopCustomersVoucher.Name = "btnGiveTopCustomersVoucher";
			btnGiveTopCustomersVoucher.Size = new System.Drawing.Size(158, 29);
			btnGiveTopCustomersVoucher.TabIndex = 1;
			btnGiveTopCustomersVoucher.Text = "Give them a voucher";
			btnGiveTopCustomersVoucher.UseVisualStyleBackColor = true;
			btnGiveTopCustomersVoucher.Click += btnGiveTopCustomersVoucher_Click;
			// 
			// lbTopCustomers
			// 
			lbTopCustomers.FormattingEnabled = true;
			lbTopCustomers.ItemHeight = 20;
			lbTopCustomers.Location = new System.Drawing.Point(39, 57);
			lbTopCustomers.Name = "lbTopCustomers";
			lbTopCustomers.Size = new System.Drawing.Size(251, 224);
			lbTopCustomers.TabIndex = 0;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabPage3.Controls.Add(lblRevenue);
			tabPage3.Controls.Add(lblSoldCoffeePerCustomer);
			tabPage3.Controls.Add(lblCoffeeSoldPerMonth);
			tabPage3.Location = new System.Drawing.Point(4, 29);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new System.Drawing.Size(656, 318);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Analytics";
			// 
			// lblRevenue
			// 
			lblRevenue.AutoSize = true;
			lblRevenue.Location = new System.Drawing.Point(23, 75);
			lblRevenue.Name = "lblRevenue";
			lblRevenue.Size = new System.Drawing.Size(107, 20);
			lblRevenue.TabIndex = 2;
			lblRevenue.Text = "No sales made";
			// 
			// lblSoldCoffeePerCustomer
			// 
			lblSoldCoffeePerCustomer.AutoSize = true;
			lblSoldCoffeePerCustomer.Location = new System.Drawing.Point(23, 177);
			lblSoldCoffeePerCustomer.Name = "lblSoldCoffeePerCustomer";
			lblSoldCoffeePerCustomer.Size = new System.Drawing.Size(107, 20);
			lblSoldCoffeePerCustomer.TabIndex = 1;
			lblSoldCoffeePerCustomer.Text = "No sales made";
			// 
			// lblCoffeeSoldPerMonth
			// 
			lblCoffeeSoldPerMonth.AutoSize = true;
			lblCoffeeSoldPerMonth.Location = new System.Drawing.Point(23, 124);
			lblCoffeeSoldPerMonth.Name = "lblCoffeeSoldPerMonth";
			lblCoffeeSoldPerMonth.Size = new System.Drawing.Size(107, 20);
			lblCoffeeSoldPerMonth.TabIndex = 0;
			lblCoffeeSoldPerMonth.Text = "No sales made";
			// 
			// lblTopCustomers
			// 
			lblTopCustomers.AutoSize = true;
			lblTopCustomers.Location = new System.Drawing.Point(39, 24);
			lblTopCustomers.Name = "lblTopCustomers";
			lblTopCustomers.Size = new System.Drawing.Size(105, 20);
			lblTopCustomers.TabIndex = 2;
			lblTopCustomers.Text = "Top customers";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			ClientSize = new System.Drawing.Size(654, 344);
			Controls.Add(tabControl1);
			Name = "MainForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "mainForm";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnLoadOrder;
		private System.Windows.Forms.Button btnSaveOrder;
		private System.Windows.Forms.Button btnLoadCustomer;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnMakeOrder;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.ListBox lbOrders;
		private System.Windows.Forms.ListBox lbCustomers;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ListBox lbCustomerOrder;
		private System.Windows.Forms.Button btnGiveOrder;
		private System.Windows.Forms.ComboBox cbbOrder;
		private System.Windows.Forms.ComboBox cbbCustomer;
		private System.Windows.Forms.Button btnUseVoucher;
		private System.Windows.Forms.Label lblCustomerOrderPrice;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lblCoffeeSoldPerMonth;
		private System.Windows.Forms.Label lblSoldCoffeePerCustomer;
		private System.Windows.Forms.Button btnRemoveCustomer;
		private System.Windows.Forms.Label lblCustomerOrders;
		private System.Windows.Forms.Label lblVoucher;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label lblRevenue;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnGiveTopCustomersVoucher;
		private System.Windows.Forms.ListBox lbTopCustomers;
		private System.Windows.Forms.Label lblTopCustomers;
	}
}