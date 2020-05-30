using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorselProgramlamaProje;


namespace And.Eticaret.Core.Model.Entity
{
	public class Status : Entity_Base
	{
		public string Name { get; set; }

	}
}