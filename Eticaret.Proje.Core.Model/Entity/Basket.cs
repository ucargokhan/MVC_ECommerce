using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And.Eticaret.Core.Model.Entity
{
	public class Basket : Entity_Base
	{
		public int UserID { get; set; }

		public int ProductID { get; set; }

		public Product Product { get; set; }

		public int Quantity { get; set; }
	}
}
