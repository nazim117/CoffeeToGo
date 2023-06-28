using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CoffeeTogo;

namespace CoffeeToGo
{
	public class DataSaver
	{
		CustomerService customerService;
		OrderService orderService;

		public DataSaver(CustomerService c, OrderService orderS)
		{
			this.customerService = c;
			this.orderService = orderS;
		}
		public void SaveCustomerData()
		{
			FileStream fs = null;
			BinaryFormatter bf = null;

			Customer[] customers = customerService.GetCustomers();
			try
			{
				fs = new FileStream("Customers", FileMode.OpenOrCreate, FileAccess.Write);
				bf = new BinaryFormatter();
				
				bf.Serialize(fs, customers);
			}
			catch (Exception ex)
			{ string message = ex.Message; }
			finally
			{ if (fs != null) { fs.Close(); } }
		}
		public void SaveOrderData()
		{
			FileStream fs = null;
			BinaryFormatter bf = null;

			Order[] orders = orderService.GetOrders();
			try
			{
				fs = new FileStream("Orders", FileMode.OpenOrCreate, FileAccess.Write);
				bf = new BinaryFormatter();

				bf.Serialize(fs, orders);
			}
			catch (Exception ex)
			{ string message = ex.Message; }
			finally
			{ if (fs != null) { fs.Close(); } }
		}
		public Customer[] LoadCustomerData()
		{
			FileStream fs = null;
			BinaryFormatter bf = null;
			try
			{
				fs = new FileStream("Customers", FileMode.Open, FileAccess.Read);
				bf = new BinaryFormatter();
				Customer[] customers = (Customer[])bf.Deserialize(fs);

				return customers;
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				return null;
			}
			finally
			{ if (fs != null) fs.Close(); }
		}
		public Order[] LoadOrderData()
		{
			FileStream fs = null;
			BinaryFormatter bf = null;
			try
			{
				fs = new FileStream("Orders", FileMode.Open, FileAccess.Read);
				bf = new BinaryFormatter();
				Order[] orders = (Order[])bf.Deserialize(fs);
				return orders;
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				return null;
			}
			finally
			{ if (fs != null) fs.Close(); }
		}

	}
}
