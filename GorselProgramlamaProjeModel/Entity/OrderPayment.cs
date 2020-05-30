using GorselProgramlamaProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaProjeModel.Entity
{
	public class OrderPayment : Entity_Base
	{
		public int _OrderID { get; set; }

		public int OrderType { get; set; }

		public decimal Price { get; set; }

		public string Bank { get; set; }
	}

	public enum _OrderType
	{
		Havale = 0,
		KrediKartı = 1
	}
}
