using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeToGo
{
	public class VoucherGenerator
	{
		List<Voucher> voucherList;
        public Voucher Voucher { get; private set; }
        public VoucherGenerator()
		{
			voucherList = new List<Voucher>();
		}
		public string GeneretaVoucherCode()
		{
			Random rnd = new Random();
			string chars = "ABCDEFGHJKLMN12345678";
			string voucherCode = string.Empty;

			for (int i = 0; i < 5; i++)
			{
				voucherCode += chars[rnd.Next(chars.Length)];
			}
			return voucherCode;
		}
		public int GenerateDiscount()
		{
			Random rnd = new Random();
			int discount = rnd.Next(1, 3);
			return discount;

		}
		public override string ToString()
		{
			return $"Voucher generator: {voucherList.Count} voucher/s)";
		}

	}
}
