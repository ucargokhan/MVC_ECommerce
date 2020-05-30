using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorselProgramlamaProje;



namespace GorselProgramlamaProje
{
	public class Entity_Base
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int ID { get; set; }

		public DateTime CreationDate { get; set; }

		public int CreatorUserId { get; set; }

		public DateTime? UpdateDate { get; set; }

		public int? UpdaterUserId { get; set; }
	}
}
