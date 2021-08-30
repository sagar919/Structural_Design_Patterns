using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern3
{
	public interface IItem
	{
		public String itemName();
		public double itemPrice();
	}
}
