using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PrintAdministrator
{
	public class Phaser : Printer
	{
		
		private decimal sale_price;
		public new decimal SalePrice
		{
			get { return sale_price; }
		}

		private decimal rent_price;
		public new decimal RentPrice
		{
			get { return rent_price; }
		}
		public Phaser(): base()
		{
			Series = "";
			sale_price = 25000;
			rent_price = 4000;

		}
		public Phaser(string series, decimal sale_price, decimal rent_price) : base(series, sale_price, rent_price)
		{
			this.Series = series;
			this.sale_price = 25000;
			this.rent_price = 4000;
		}
	}
}
