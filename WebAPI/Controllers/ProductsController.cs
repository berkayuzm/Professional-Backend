using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productDal) {
            _productService = productDal;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _productService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result= _productService.Add(product);
            return Ok(result);
        }
    }
}
