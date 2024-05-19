using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PrintAdministrator
{
	public class Sales
	{
		private string size;

		public string Size
		{
			get { return size; }
			set { size = value; }
		}

		private string availablepapersale;

		public string AvailablePaperSales
		{
			get { return availablepapersale; }
			set { availablepapersale = value; }
		}

		private string sales_options;

		public string Salesoptions
		{
			get { return sales_options; }
			set { sales_options = value; }
		}

		private decimal priceSale;

		public decimal PriceSale
		{
			get { return priceSale; }
			set { priceSale = value; }
		}

		private int numberprints;

		public int Numberprints
		{
			get { return numberprints; }
			set { numberprints = value; }
		}

		public Sales()
		{
			this.size = "";
			this.availablepapersale = "";
			this.sales_options = "";
			this.priceSale = 0;
			this.numberprints = 0;
			
		}
		public Sales(string size, string availablepapersale, string sales_options, decimal priceSale, int numberprints, decimal total)
		{
			this.size = size;
			this.availablepapersale = availablepapersale;
			this.sales_options = sales_options;
			this.priceSale = priceSale;
			this.numberprints = numberprints;
			
		}

	
		public decimal Calculates_totalsale()
		{
			decimal total = 0;
			switch (sales_options)
			{
				case "Pricepacket":
					total = priceSale * numberprints;
					break;
				case "Priceprint":
					total = priceSale * numberprints;
					break;
				case "WhitesheetPrice":
					total = priceSale * numberprints;
					break;
			}
			return total;
		}


	}
}
