using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<Product> products = new List<Product>()
			{
				new Product{ ID=1,Name="吐司" },
				new Product{ ID=2,Name="泡芙" },
				new Product{ ID=3,Name="三明治" }
			};

			
			
			

		}
		class Product
		{
			public int ID { get; set; }
			public string Name{ get; set; }



		}
	}
}
