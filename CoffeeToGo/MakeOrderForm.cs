using CoffeeToGo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeTogo
{
	public partial class MakeOrderForm : Form
	{
		OrderService orderService;
		MainForm mainForm;

		public MakeOrderForm(OrderService orderS, MainForm mainForm)
		{
			InitializeComponent();
			orderService = orderS;
			this.mainForm = mainForm;
			foreach (var item in Enum.GetValues(typeof(CoffeeSize)))
			{
				cbbCoffeeSize.Items.Add(item);
			}
			chlbExtras.Items.AddRange(orderService.GetExtras());
			foreach (var item in Enum.GetValues(typeof(CoffeeType)))
			{
				cbbType.Items.Add(item);
			}

		}
		public void btnFinishOrder_Click_1(object sender, EventArgs e)
		{
			bool isSpecial = false;
			if (rdbYes.Checked)
			{
				isSpecial = true;
			}
			if (rdbNo.Checked)
			{
				isSpecial = false;
			}

			if (cbbCoffeeSize.SelectedItem != null && cbbType.SelectedItem != null)
			{
				double price = 0;
				for (int i = 0; i < chlbExtras.CheckedItems.Count; i++)
				{
					price += ((Extras)chlbExtras.CheckedItems[i]).Price;

				}

				orderService.MakeOrder((CoffeeSize)cbbCoffeeSize.SelectedItem, (CoffeeType)cbbType.SelectedItem, isSpecial, price);

				foreach (Extras item in chlbExtras.CheckedItems)
				{
					orderService.Order.AddExtras(item);
				}
				orderService.AddOrder(orderService.Order);

				MessageBox.Show("The order was made");

				mainForm.UpdateCbbOrders(orderService.GetOrders());

			}
			else
			{
				MessageBox.Show("Fill in every field!");
				return;
			}
		}

		private void MakeOrderForm_Load(object sender, EventArgs e)
		{

		}

		private void lblPrice_Click(object sender, EventArgs e)
		{

		}
	}
}
