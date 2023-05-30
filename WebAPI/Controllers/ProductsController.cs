using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result=productManager.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetById(id);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result= productManager.Add(product);
            return Ok(result);
        }
    }
}
