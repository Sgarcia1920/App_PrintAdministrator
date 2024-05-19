using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App_PrintAdministrator
{
	public class TypePaper
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string size;

		public string Size
		{
			get { return size; }
			set { size = value; }
		}
		
		private decimal pricepacket;
		public decimal Pricepacket
		{
			get { return pricepacket; }
			set { pricepacket = value; }
		}


		private decimal priceprint;
		public decimal Priceprint
		{
			get { return priceprint; }
			set { priceprint = value; }
		}

		private decimal white_sheetPrice;
		public decimal WhitesheetPrice
		{
			get { return white_sheetPrice; }
			set { white_sheetPrice = value; }
		}

		public TypePaper()
		{
			this.name = "";
			this.size = "";
			this.pricepacket = 0;
			this.priceprint = 0;
			this.white_sheetPrice = 0;
		}
		public TypePaper(string name, string size, double package_weight, decimal pricepacket, decimal priceprint, decimal white_sheetPrice)
		{
			this.name = name;
			this.size = size;
			this.pricepacket = pricepacket;
			this.priceprint = priceprint;
			this.white_sheetPrice = white_sheetPrice;
		}
		public override string ToString()
		{
			return name + " " + size +  " " + pricepacket + " " + priceprint + " " + white_sheetPrice;
		}


	}
}
