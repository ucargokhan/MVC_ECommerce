using And.Eticaret.Core.Model.Entity;
using GorselProgramlamaProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaProjeModel.Entity
{
	public class OrderProduct : Entity_Base

	{
		public int OrderID { get; set; }

		public int ProductID { get; set; }

		public Product Product { get; set; }

		public int Quantity { get; set; }
	}
}
