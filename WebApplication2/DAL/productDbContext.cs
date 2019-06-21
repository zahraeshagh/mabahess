using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAL
{

	public class productDbContext:DbContext
	{
		public productDbContext()
			: base("conectioncontext")
		{

		}
		public DbSet<product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Company>Companies{ get; set;}
		public DbSet<country>Countries{ get; set;}
}
	}