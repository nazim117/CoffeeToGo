using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeToGo
{
	[Serializable]
	public class Voucher
	{
        public string VoucherCode { get; private set; }
        public double Discount { get; private set; }

        public Voucher(string voucherCode, int voucherDiscount)
        {
			this.VoucherCode = voucherCode;
			this.Discount = voucherDiscount;
        }
		public override string ToString()
		{
			return $"Voucher code: {VoucherCode} (discount -{Discount:f2} euro)";
		}


	}
}
