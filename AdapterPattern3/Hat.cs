using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern3
{
	public class Hat
	{
		private String shortName;
		private String longName;
		private double basePrice;
		private double GST = 0.08;

		public Hat(String shortName, String longName, double basePrice)
		{
			this.shortName = shortName;
			this.longName = longName;
			this.basePrice = basePrice;
		}

		public String getShortName()
		{
			return shortName;
		}

		public String getLongName()
		{
			return longName;
		}

		public double getPrice()
		{
			return basePrice + (basePrice * GST);
		}

		public double getGST()
		{
			return GST;
		}

	}
}
