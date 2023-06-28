using CoffeeToGo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeTogo
{
	public class OrderService
	{

        private List<Order> orders;
		private List<Extras> extras;
		private double revenue = 0;
        public string Name { get;}
		public Order Order { get; private set; }
        public OrderService(string name)
        {
			this.Name = name;
			orders  = new List<Order>();
			extras = new List<Extras>()
			{
				new Extras("Donuts", 1.2),
				new Extras("Chocolate", 0.8),
				new Extras("Caramel", 0.5),
				new Extras("Croissant", 1.5),
				new Extras("Chocolate Cake", 2.6),
			};
		}

		public Order MakeOrder(CoffeeSize size, CoffeeType coffeeType, bool isSpecial, double price)
		{
			Order = new Order(size, coffeeType, isSpecial, price);
			Order.Special(isSpecial);
			return Order;
		}
		public void AddOrder(Order o)
		{
			if (!orders.Contains(o))
			{
				orders.Add(o);
			}
		}
		public double CalculateRevenue(Order order)
		{
			if (orders.Count > 0)
			{
				revenue += order.Price;
			}
			return revenue;
		}
		public double UseVoucher(Customer customerWithVoucher)
		{
			if (customerWithVoucher.Voucher != null)
			{
				revenue -= customerWithVoucher.Voucher.Discount;

				customerWithVoucher.CalculateVoucherOrderPrice();
				customerWithVoucher.RemoveVoucherFromCustomer();
			}
			return revenue;
		}
		public Order GetOrderInfo(int selectedIndex) { return orders[selectedIndex]; }
		public Order[] GetOrders() { return orders.ToArray(); }
		public Extras[] GetExtras() { return extras.ToArray(); }

		public override string ToString()
		{
			return $"Order service: {Name} ({orders.Count} order/s)";
		}
	}
}
