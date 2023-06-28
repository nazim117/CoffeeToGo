namespace CoffeeTogo
{
	partial class MakeOrderForm
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
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			btnFinishOrder = new System.Windows.Forms.Button();
			chlbExtras = new System.Windows.Forms.CheckedListBox();
			rdbNo = new System.Windows.Forms.RadioButton();
			rdbYes = new System.Windows.Forms.RadioButton();
			cbbType = new System.Windows.Forms.ComboBox();
			cbbCoffeeSize = new System.Windows.Forms.ComboBox();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(22, 305);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(118, 20);
			label4.TabIndex = 20;
			label4.Text = "Extras (optional)";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(22, 156);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(57, 20);
			label3.TabIndex = 19;
			label3.Text = "Special";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(22, 88);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(40, 20);
			label2.TabIndex = 18;
			label2.Text = "Type";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(22, 18);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(36, 20);
			label1.TabIndex = 17;
			label1.Text = "Size";
			// 
			// btnFinishOrder
			// 
			btnFinishOrder.Location = new System.Drawing.Point(22, 478);
			btnFinishOrder.Name = "btnFinishOrder";
			btnFinishOrder.Size = new System.Drawing.Size(232, 29);
			btnFinishOrder.TabIndex = 16;
			btnFinishOrder.Text = "Make Order";
			btnFinishOrder.UseVisualStyleBackColor = true;
			btnFinishOrder.Click += btnFinishOrder_Click_1;
			// 
			// chlbExtras
			// 
			chlbExtras.FormattingEnabled = true;
			chlbExtras.Location = new System.Drawing.Point(22, 328);
			chlbExtras.Name = "chlbExtras";
			chlbExtras.Size = new System.Drawing.Size(232, 114);
			chlbExtras.TabIndex = 15;
			// 
			// rdbNo
			// 
			rdbNo.AutoSize = true;
			rdbNo.BackColor = System.Drawing.SystemColors.Control;
			rdbNo.Checked = true;
			rdbNo.Location = new System.Drawing.Point(64, 240);
			rdbNo.Name = "rdbNo";
			rdbNo.Size = new System.Drawing.Size(50, 24);
			rdbNo.TabIndex = 14;
			rdbNo.TabStop = true;
			rdbNo.Text = "No";
			rdbNo.UseVisualStyleBackColor = false;
			// 
			// rdbYes
			// 
			rdbYes.AutoSize = true;
			rdbYes.BackColor = System.Drawing.SystemColors.Control;
			rdbYes.Location = new System.Drawing.Point(64, 201);
			rdbYes.Name = "rdbYes";
			rdbYes.Size = new System.Drawing.Size(144, 24);
			rdbYes.TabIndex = 13;
			rdbYes.Text = "Yes (+ 0.50 cents)";
			rdbYes.UseVisualStyleBackColor = false;
			// 
			// cbbType
			// 
			cbbType.FormattingEnabled = true;
			cbbType.Location = new System.Drawing.Point(22, 111);
			cbbType.Name = "cbbType";
			cbbType.Size = new System.Drawing.Size(232, 28);
			cbbType.TabIndex = 12;
			// 
			// cbbCoffeeSize
			// 
			cbbCoffeeSize.FormattingEnabled = true;
			cbbCoffeeSize.Location = new System.Drawing.Point(22, 41);
			cbbCoffeeSize.Name = "cbbCoffeeSize";
			cbbCoffeeSize.Size = new System.Drawing.Size(232, 28);
			cbbCoffeeSize.TabIndex = 11;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(22, 179);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new System.Drawing.Size(232, 105);
			dataGridView1.TabIndex = 22;
			// 
			// MakeOrderForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			ClientSize = new System.Drawing.Size(295, 538);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnFinishOrder);
			Controls.Add(chlbExtras);
			Controls.Add(rdbNo);
			Controls.Add(rdbYes);
			Controls.Add(cbbType);
			Controls.Add(cbbCoffeeSize);
			Controls.Add(dataGridView1);
			Name = "MakeOrderForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "MakeOrderForm";
			Load += MakeOrderForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFinishOrder;
		private System.Windows.Forms.CheckedListBox chlbExtras;
		private System.Windows.Forms.RadioButton rdbNo;
		private System.Windows.Forms.RadioButton rdbYes;
		private System.Windows.Forms.ComboBox cbbType;
		private System.Windows.Forms.ComboBox cbbCoffeeSize;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}