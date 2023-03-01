using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShopCodeFirstFromDB
{
	partial class Customer
	{
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return CustomerId + ": " + Name;
		}
	}

	partial class Inventory
	{

		public override string ToString()
		{
			return InventoryId + ": " + Name;
		}
	}

	partial class Category
	{
		public override string ToString()
		{
			return Description;
		}
	}


}
