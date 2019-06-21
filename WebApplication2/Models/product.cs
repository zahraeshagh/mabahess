using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
	public class product
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Please fill")]
		[Display(Name = "شناسه اقلام")]
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Please fill")]
		[Display(Name = "شناسه برند")]
		public int BrandId { get; set; }
		[Required(ErrorMessage = "Please fill")]

		[Display(Name = "نام مدل")]
		public string ModeldName { get; set; }

		[Display(Name = "توضیحات")]
		public string Description { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public virtual Category category { get; set; }

		[ForeignKey(nameof(BrandId))]
		public virtual Company Brand { get; set; }


	}

}