using GorselProgramlamaProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And.Eticaret.Core.Model.Entity
{
	public class Product : Entity_Base
	{
		public string Name {get; set;}

		public int CategoryID { get; set; }

		public Category Category { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public string ImageURL { get; set; }

		public string Description {get; set;}

		public Decimal Discount {get; set;}

		public Decimal Price {get; set;}

		public Decimal Tax { get; set; }

		public int Stock {get; set;}

		public bool IsActive { get; set; }
	}
}
