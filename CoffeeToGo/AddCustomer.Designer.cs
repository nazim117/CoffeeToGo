namespace CoffeeTogo
{
	partial class AddCustomer
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
			txtName = new System.Windows.Forms.TextBox();
			txtEmail = new System.Windows.Forms.TextBox();
			txtPhoneNum = new System.Windows.Forms.TextBox();
			btnCreateCustomer = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// txtName
			// 
			txtName.Location = new System.Drawing.Point(75, 53);
			txtName.Name = "txtName";
			txtName.Size = new System.Drawing.Size(125, 27);
			txtName.TabIndex = 0;
			// 
			// txtEmail
			// 
			txtEmail.Location = new System.Drawing.Point(75, 129);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(125, 27);
			txtEmail.TabIndex = 1;
			// 
			// txtPhoneNum
			// 
			txtPhoneNum.Location = new System.Drawing.Point(75, 193);
			txtPhoneNum.Name = "txtPhoneNum";
			txtPhoneNum.Size = new System.Drawing.Size(125, 27);
			txtPhoneNum.TabIndex = 2;
			txtPhoneNum.TextChanged += txtPhoneNum_TextChanged;
			// 
			// btnCreateCustomer
			// 
			btnCreateCustomer.Location = new System.Drawing.Point(27, 246);
			btnCreateCustomer.Name = "btnCreateCustomer";
			btnCreateCustomer.Size = new System.Drawing.Size(216, 29);
			btnCreateCustomer.TabIndex = 3;
			btnCreateCustomer.Text = "Create Customer";
			btnCreateCustomer.UseVisualStyleBackColor = true;
			btnCreateCustomer.Click += btnCreateCustomer_Click_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(75, 30);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(49, 20);
			label1.TabIndex = 4;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(75, 106);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(46, 20);
			label2.TabIndex = 5;
			label2.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(75, 170);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(120, 20);
			label3.TabIndex = 6;
			label3.Text = "Phone (optional)";
			// 
			// AddCustomer
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			ClientSize = new System.Drawing.Size(269, 315);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCreateCustomer);
			Controls.Add(txtPhoneNum);
			Controls.Add(txtEmail);
			Controls.Add(txtName);
			Name = "AddCustomer";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "AddCustomer";
			Load += AddCustomer_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhoneNum;
		private System.Windows.Forms.Button btnCreateCustomer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}