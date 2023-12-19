using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TranXuanPhuc_N03_201200278.Models;

namespace TranXuanPhuc_N03_201200278.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly QLBanNoiContext _context;
        public ProductsController(QLBanNoiContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetProducts(string id) {

            var products = _context.SanPhams.Where(p => p.MaPhanLoaiPhu == id).ToList();

            return Ok(products);
        }
    }
}
