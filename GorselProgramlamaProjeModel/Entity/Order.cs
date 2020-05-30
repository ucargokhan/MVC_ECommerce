using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorselProgramlamaProje;
using GorselProgramlamaProjeModel.Entity;
using And.Eticaret.Core.Model.Entity;



namespace And.Eticaret.Core.Model.Entity
{
	public class Order : Entity_Base
	{
		public int UserAddressID { get; set; }

		public int UserID { get; set; }

		public User User { get; set; }

		public UserAddress UserAddress { get; set; }

		public Status Status { get; set; }

		public decimal TotalProductPrice { get; set; }

		public decimal TotalTaxPrice { get; set; }

		public decimal TotalDiscountPrice { get; set; }

		public decimal TotalPrice { get; set; }

		public virtual List <Order> OrderPayment { get; set; }

		public virtual List<OrderProduct> OrderProducts { get; set; }
	}
}