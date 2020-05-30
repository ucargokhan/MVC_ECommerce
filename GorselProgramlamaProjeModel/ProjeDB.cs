using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using And.Eticaret.Core.Model.Entity;
using GorselProgramlamaProjeModel;
using GorselProgramlamaProjeModel.Entity;


namespace GorselProgramlamaProje
{
	public class ProjeDB : DbContext
	{
		public ProjeDB()
		: base(@"Data Source=DESKTOP-I5LDHRS\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
		{
		}


		public DbSet<User> Users { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<UserAddress> Addresses { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Status> Statuses { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<Basket> Baskets { get; set; }

		public DbSet<OrderProduct> OrderProducts { get; set; }

		public DbSet<OrderPayment> OrderPayments { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			base.OnModelCreating(modelBuilder);
		}

	}
}
