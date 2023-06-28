using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeeToGo
{
	[Serializable]
	public class Customer
	{
		private double orderTotal = 0;
		private List<Order> orders;
		private List<Order> ordersForVoucher = new List<Order>();
        public Voucher Voucher { get; private set; }
        public string CustomerName { get; }
		public string CustomerEmail { get; }
		public string CustomerPhone { get; }

		public Customer(string name, string email)
		{
			this.CustomerName = name;
			this.CustomerEmail = email;
			orders = new List<Order>();
		}
		public Customer(string name, string email, string phone)
		{
			this.CustomerName = name;
			this.CustomerEmail = email;
			this.CustomerPhone = phone;
			orders = new List<Order>();
		}
		public void AddOrderToCustomer(Order order)
		{
			orders.Add(order);
			if (Voucher == null) 
			{
				ordersForVoucher.Add(order);
			}

			CalculateOrderPrice(order);
		} 
		public void AddVoucherToCustomer(Voucher voucher)
		{
			Voucher = voucher;
			ordersForVoucher = new List<Order>();
		}
		public void RemoveVoucherFromCustomer()
		{
			Voucher = null;
		}
		public void CalculateOrderPrice(Order order) 
		{
			orderTotal += order.Price;
		}
		public void CalculateVoucherOrderPrice()
		{
			orderTotal -= Voucher.Discount;
		}
		public Order[] GetCustomerOrders(){ return orders.ToArray(); }
		public Order[] GetCustomerOrdersForVoucher(){ return ordersForVoucher.ToArray(); }
		public double GetCustomerOrderPrice(){ return orderTotal; }
		public Order GetSpecificOrder(int index){ return orders[index]; }
		public override string ToString()
		{
			if (CustomerPhone != null)
				return $"{CustomerName} - Email: {CustomerEmail}, Phone: {CustomerPhone}";
			else
				return $"{CustomerName} - Email: {CustomerEmail}";
		}
		public override bool Equals(object obj)
		{
			Customer cust = obj as Customer;
			if (cust == null)
				return false;
			else
				return CustomerName == ((Customer)obj).CustomerName && CustomerEmail == ((Customer)obj).CustomerEmail;
		}
	}
}
