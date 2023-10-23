using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_01.Data;
using WebAPI_01.Models;

namespace WebAPI_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductTypeController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productTypes = _context.ProductTypes.ToList();
            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var productType = _context.ProductTypes.SingleOrDefault(lo=>lo.Id == id);
            if(productType != null)
            {
                return Ok(productType);
            }
            else
            {
                return NotFound();
            }
           
        }

        [HttpPost]
        public IActionResult CreateNew(ProductTypeModel model)
        {
            try
            {
                var productType = new ProductType
                {
                    Code = model.Code,
                    Name = model.Name,
                    Description = model.Description
                };
                _context.Add(productType);
                _context.SaveChanges();
                return Ok(productType);
            }
            catch
            {
                return BadRequest();    
            }
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductTypeModel model)
        {
            var productType = _context.ProductTypes.SingleOrDefault(lo => lo.Id == id);
            if (productType != null)
            {
                productType.Code = model.Code;
                productType.Name = model.Name;  
                productType.Description = model.Description;
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }

        }

    }
}
