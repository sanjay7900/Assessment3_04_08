using BookListWebApiAssessment3.Data;
using BookListWebApiAssessment3.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookListWebApiAssessment3.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        private BooKListContext _context;
        public CartController(BooKListContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var crt = _context.Cart.ToList();
            var json= JsonConvert.SerializeObject(crt);
            return Ok(json);
        }
        [HttpPost]
        public IActionResult Create(cart data )
        {
            _context.Cart.Add(data);
            _context.SaveChanges(); 
            return Ok();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var crt = _context.Cart.Where(x => x.Id == id).FirstOrDefault();
            _context.Cart.Remove(crt);
            _context.SaveChanges();

            return Ok();    
        }
    }
}
