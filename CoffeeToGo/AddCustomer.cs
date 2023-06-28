using CoffeeToGo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace CoffeeTogo
{
	public partial class AddCustomer : Form
	{
		CustomerService customerService;
		MainForm mainForm;
		public AddCustomer(CustomerService c, MainForm m)
		{
			InitializeComponent();
			customerService = c;
			mainForm = m;
		}

		private void AddCustomer_Load(object sender, EventArgs e)
		{
		}
		private void txtPhoneNum_TextChanged(object sender, EventArgs e)
		{
		}
		private void btnCreateCustomer_Click_1(object sender, EventArgs e)
		{
			if (txtPhoneNum.Text != string.Empty)
			{
				customerService.AddCustomer(txtName.Text, txtEmail.Text, txtPhoneNum.Text);
				MessageBox.Show("Customer was added successfully");

				mainForm.UpdateCbbCustomers(customerService.GetCustomers());
			}
			else if (txtName.Text != string.Empty && txtEmail.Text != string.Empty)
			{
				customerService.AddCustomerNoPhoneNr(txtName.Text, txtEmail.Text);
				MessageBox.Show("Customer was added successfully (no phone number)");

				mainForm.UpdateCbbCustomers(customerService.GetCustomers());
			}
			else
				MessageBox.Show("Fill in all the required fields!");
			this.Close();

		}
	}
}
