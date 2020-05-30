using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using And.Eticaret.Core.Model.Entity;

namespace And.Eticaret.Core.Model
{
	public class EticaretDB :DbContext
	{
		//DB Tabloları
		public EticaretDB()
		{ 
			
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<UserAddress> Addresses { get; set; }

		public DbSet <Product> Products { get; set; }

		public DbSet <Status> Statuses { get; set; }

		public DbSet <Basket> Baskets { get; set; }





	}
}
