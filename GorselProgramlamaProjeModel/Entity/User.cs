﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using And.Eticaret.Core.Model.Entity;
using GorselProgramlamaProje;


namespace GorselProgramlamaProjeModel.Entity
{
	public class User : Entity_Base
	{
		public string Name { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string TelephoneNumber { get; set; }

		public string Password { get; set; }

		public string TCNO { get; set; }

		public bool IsActive { get; set; }

		public bool IsAdmin { get; set; }

		public virtual IEnumerable<UserAddress> UserAddress { get; set; }


	}
}