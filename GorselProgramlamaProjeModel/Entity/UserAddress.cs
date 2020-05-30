﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorselProgramlamaProje;
using GorselProgramlamaProjeModel.Entity;

namespace And.Eticaret.Core.Model.Entity
{
	public class UserAddress : Entity_Base
	{
		public int UserID { get; set; }

		public User User { get; set; }

		public string Title { get; set; }

		public string City { get; set; }

		public string Address { get; set; }

		public bool IsActive { get; set; }


	}
}
