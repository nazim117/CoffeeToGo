using CoffeeTogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeToGo
{
	public class CustomerService
	{
        private List<Customer> customers;
		private List<Customer> topCustomers;
		public string Name { get; }
        public Customer Customer { get; private set; }

		public CustomerService(string name)
		{
			this.Name = name;
			customers = new List<Customer>();
			topCustomers= new List<Customer>();
		}
		public void AddCustomerNoPhoneNr(string name, string email)
		{
			Customer= new Customer(name, email);
			customers.Add(Customer);
		}

		public void AddCustomer(string name, string email, string address)
		{
			Customer = new Customer(name, email, address);
			customers.Add(Customer);
		}
		public void CreateVoucherForEachCustomer()
		{
			if (topCustomers.Count >= 5)
			{
				for (int i = 0; i < 5; i++)
				{
					VoucherGenerator voucherGenerator = new VoucherGenerator();
					Voucher voucher = new Voucher(voucherGenerator.GeneretaVoucherCode(), voucherGenerator.GenerateDiscount());

					topCustomers[i].AddVoucherToCustomer(voucher);
				}
			}
		}
		public void CreateCustomerVoucher(Customer customer)
		{
				if (customer.GetCustomerOrdersForVoucher().Length == 10)
				{
					VoucherGenerator voucherGenerator = new VoucherGenerator();
					Voucher voucher = new Voucher(voucherGenerator.GeneretaVoucherCode(), voucherGenerator.GenerateDiscount());

					customer.AddVoucherToCustomer(voucher);
				}
			
		}
		public void AddTopCustomers(Customer customer)
		{
			if (!topCustomers.Contains(customer))
			{
				topCustomers.Add(customer);
			}	
		}
		public void RemoveCustomer(Customer cust)
		{
			customers.Remove(cust);
		}
		public Customer[] GetCustomers(){ return customers.ToArray(); }
		public Customer[] GetTopCustomers() { return topCustomers.ToArray(); }
		public Order[] GetAllCustomerOrders()
		{
			List<Order> ordersForToday = new List<Order>();
			foreach (Customer everyCustomer in customers)
			{
				foreach (Order orderPerCustomer in everyCustomer.GetCustomerOrders())
				{
					ordersForToday.Add(orderPerCustomer);
				}
			}
			
			return ordersForToday.ToArray();
		}
		public override string ToString()
		{
			return $"Customer Service: {Name} ({customers.Count} customer/s)";
		}
	}
}
