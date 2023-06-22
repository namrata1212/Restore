﻿using System.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
	public class StoreContext : DbContext
	{
		public StoreContext(DbContextOptions option) : base(option)
		{

		}

		public DbSet<Product> Products { get; set; }
	}
}
