using CoffeeTogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeToGo
{
	[Serializable]
	public class Order
	{
		private static int id = 1;
		private int orderId;
		private double price = 1.5;
		private List<Extras> extras;
		public CoffeeType CoffeeType { get; }
		public double Price { get { return price; } private set { price = value; } }
		public bool IsSpecial { get; }
		public CoffeeSize Size { get; }

		public Order(CoffeeSize size, CoffeeType coffeeType, bool isSpecial, double basePrice)
		{
			orderId = id++;
			this.Size = size;
			this.CoffeeType = coffeeType;
			this.IsSpecial = isSpecial;
			this.Price += basePrice;
			extras = new List<Extras>();
		}

		public void AddExtras(Extras e)
		{
			if (extras.Count < 5)
			{
				extras.Add(e);
			}

		}
		public void Special(bool isSpecial)
		{
			if (isSpecial)
			{
				Price += 0.5;
			}
		}
		public override string ToString()
		{
			return $"{orderId}: {CoffeeType}, Price {Price} euro (CoffeeSize: {Size}, Extras: {extras.Count}, Special: {IsSpecial})";
		}
	}
}
