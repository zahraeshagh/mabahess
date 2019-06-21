using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
	public class Company
	
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Please fill")]
		[Display(Name = "نام فارسی")]
		public string PersianName { get; set; }
		[Display(Name = "نام انگلیسی")]
		public string EnglishName { get; set; }
		public int CountryId { get; set; }

		[ForeignKey(nameof(CountryId))]
		public virtual country Country { get; set; }

		

	}
}