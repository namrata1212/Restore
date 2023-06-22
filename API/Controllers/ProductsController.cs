using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductsController : ControllerBase
	{
		public readonly StoreContext _context;
		public ProductsController(StoreContext context)
		{
			this._context = context ?? throw new ArgumentNullException(nameof(context));
		}

		[HttpGet]
		public async Task<ActionResult<List<Product>>> GetProducts()
		{
			 var products = await _context.Products.ToListAsync();

			return Ok(products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			var product = await _context.Products.FindAsync(id);

			return Ok(product);
		}

	}
}
