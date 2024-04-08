using ME_api.Database;
using ME_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ME_api.Controllers
{
    [Route("[controller]")]
    public class MainCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MainCategoryController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet,Route("get-all")]
        public IActionResult GetAllMainCategory()
        {
            List<MainCategory> result = _context.MainCategories.ToList();

            return Ok(result);
           
        }

        [HttpPost, Route("add-new-category")]
        public IActionResult AddNewCategory([FromBody] MainCategory category)
        {
            if (category != null)
            {
                _context.MainCategories.Add(category);
                _context.SaveChanges();
                return Ok(true);

            } else
            {

                return NotFound();
            }


        }
    }
}
