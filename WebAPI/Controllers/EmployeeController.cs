using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            var result= employeeManager.GetAll();
            return Ok(result.Data);
        }
    }
}
