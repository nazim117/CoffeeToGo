using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeToGo
{
    [Serializable]
	public class Extras
	{
        public string Name { get;}
        public double Price { get;}

        public Extras(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
