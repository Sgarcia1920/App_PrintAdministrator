using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PrintAdministrator
{
	public class Printer
	{
		private string brand ;
		public string Brand
		{
			get { return brand; }
		}

		
		private string series;

		public string Series
		{
			get { return series; }
			set { series = value; }
		}

		private decimal sale_price;
		public  decimal SalePrice
		{
			get { return sale_price; }
		}
	

		private decimal rent_price;
		public decimal RentPrice
		{
			get { return rent_price; }
		}
		public Printer()
		{
			brand = "XEROX";
			series = "";
			sale_price = 0;
			rent_price = 0;
			
		}
		public Printer(string series, decimal sale_price, decimal rent_price)
		{
			this.brand = "XEROX";
			this.series = series;
			this.sale_price = sale_price;
			this.rent_price = rent_price;
		}

		public string ShowBrand()
		{
			return brand;
		}

		

	}
}
