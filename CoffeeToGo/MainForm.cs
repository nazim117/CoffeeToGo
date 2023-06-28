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
	public partial class MainForm : Form
	{
		CustomerService customerService;
		OrderService orderService;
		DataSaver dataSaver;
		Customer customer;
		public MainForm()
		{
			InitializeComponent();
			customerService = new CustomerService("RoastedBeans");
			orderService = new OrderService("RoastedBeans");
			dataSaver = new DataSaver(customerService, orderService);
			lblCustomerOrderPrice.Text = "No customer selected";
		}

		private void btnAddCustomer_Click_1(object sender, EventArgs e)
		{
			AddCustomer addCustomer = new AddCustomer(customerService, this);
			addCustomer.Show();

		}

		private void btnMakeOrder_Click(object sender, EventArgs e)
		{
			MakeOrderForm makeOrderForm = new MakeOrderForm(orderService, this);
			makeOrderForm.Show();
		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{
			dataSaver.SaveCustomerData();
		}

		private void btnLoadCustomer_Click(object sender, EventArgs e)
		{
			lbCustomers.Items.Clear();
			lbCustomers.Items.AddRange(dataSaver.LoadCustomerData());
		}

		private void btnSaveOrder_Click(object sender, EventArgs e)
		{
			dataSaver.SaveOrderData();
		}

		private void btnLoadOrder_Click(object sender, EventArgs e)
		{
			lbOrders.Items.Clear();
			lbOrders.Items.AddRange(dataSaver.LoadOrderData());
		}

		private void btnGiveOrder_Click(object sender, EventArgs e)
		{
			if (cbbCustomer.SelectedItem != null && cbbOrder.SelectedItem != null)
			{
				customer = (Customer)cbbCustomer.SelectedItem;
				Order order = (Order)cbbOrder.SelectedItem;

				customer.AddOrderToCustomer(order);

				customerService.CreateCustomerVoucher(customer);
				customerService.AddTopCustomers(customer);

				if (customer.Voucher != null)
				{
					lblVoucher.Text = customer.Voucher.ToString();
				}

				UpdateListBoxAfterGiveOrder();
				UpdateAnalyticsLabels(order);
			}
			else
			{
				MessageBox.Show("Fill in every box");
			}
		}

		private void UpdateListBoxAfterGiveOrder()
		{
			lbCustomerOrder.Items.Clear();
			lbCustomerOrder.Items.AddRange(customer.GetCustomerOrders());

			lbTopCustomers.Items.Clear();
			lbTopCustomers.Items.AddRange(customerService.GetTopCustomers());
		}

		private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			customer = (Customer)cbbCustomer.SelectedItem;
			if (customer.Voucher != null)
			{
				lblVoucher.Text = customer.Voucher.ToString();
				UpdateAfterComboboxChange();
			}
			else if (customer != null)
			{
				lblVoucher.Text = "No voucher";
				UpdateAfterComboboxChange();
			}

		}

		private void UpdateAfterComboboxChange()
		{
			lbCustomerOrder.Items.Clear();
			lbCustomerOrder.Items.AddRange(customer.GetCustomerOrders());

			lblCustomerOrders.Text =
								$"{customer.CustomerName} here are your orders";

			lblCustomerOrderPrice.Text =
				$"{customer.CustomerName}: {customer.GetCustomerOrderPrice():f2} euro";
		}

		internal void UpdateCbbCustomers(Customer[] customers)
		{
			cbbCustomer.Items.Clear();
			cbbCustomer.Items.AddRange(customers);
		}

		internal void UpdateCbbOrders(Order[] orders)
		{
			cbbOrder.Items.Clear();
			cbbOrder.Items.AddRange(orders);
		}

		private void btnUseVoucher_Click(object sender, EventArgs e)
		{
			if (customer == null)
			{
				MessageBox.Show("No customers in the system");
				return;
			}

			if (customer.Voucher != null)
			{
				lblRevenue.Text =
					$"Total revenue: {orderService.UseVoucher(customer):f2} euro";

				lblCustomerOrderPrice.Text =
					$"{customer.CustomerName}: {customer.GetCustomerOrderPrice():f2} euro";

				MessageBox.Show("You used your voucher!");

				lblVoucher.Text = "No voucher";
			}
			else
			{
				MessageBox.Show("You need to buy 3 coffees to get a voucher");
			}
		}

		private void lbCustomerOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show($"{customer.GetSpecificOrder(lbCustomerOrder.SelectedIndex)}");
		}

		private void btnRemoveCustomer_Click(object sender, EventArgs e)
		{
			if (lbCustomers.SelectedItem != null)
			{
				Customer customerToBeDeleted = (Customer)lbCustomers.SelectedItem;

				customerService.RemoveCustomer(customerToBeDeleted);

				dataSaver.SaveCustomerData();

				UpdateCustomerListBox();

				UpdateCustomerCombobox();

				lbCustomerOrder.Items.Clear();
			}
			else
			{
				MessageBox.Show("Select a customer to delete");
			}
		}
		private void UpdateCustomerListBox()
		{
			lbCustomers.Items.Clear();
			lbCustomers.Items.AddRange(customerService.GetCustomers());
		}
		private void UpdateCustomerCombobox()
		{
			cbbCustomer.Items.Clear();
			cbbCustomer.Items.AddRange(customerService.GetCustomers());
		}
		private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show($"{orderService.GetOrderInfo(lbOrders.SelectedIndex)}");
		}
		private void UpdateAnalyticsLabels(Order order)
		{
			lblCustomerOrderPrice.Text =
				$"{customer.CustomerName}: {customer.GetCustomerOrderPrice():f2} euro";

			lblRevenue.Text =
				$"Total revenue: {orderService.CalculateRevenue(order):f2} euro";

			lblCoffeeSoldPerMonth.Text =
				$"Total amount of coffee sold per month: " +
				$"{customerService.GetAllCustomerOrders().Length * 30} coffees/month";

			lblSoldCoffeePerCustomer.Text =
				$"total amount of coffee sold per customer: " +
				$"{(double)customerService.GetAllCustomerOrders().Length / customerService.GetCustomers().Length:f2} " +
				$"(average coffees/customer)";
		}

		private void btnGiveTopCustomersVoucher_Click(object sender, EventArgs e)
		{
			if (customerService.GetTopCustomers().Length >= 5)
			{
				customerService.CreateVoucherForEachCustomer();

				
				foreach (Customer luckyCustomer in customerService.GetTopCustomers())
				{
					if (luckyCustomer.Voucher != null)
					{
						lblVoucher.Text = customer.Voucher.ToString();
					}
				}
				MessageBox.Show("Your customers received their vouchers");
			}
			else
			{
				MessageBox.Show($"You need {5 - customerService.GetTopCustomers().Length} customers more");
			}

		}
	}
}
