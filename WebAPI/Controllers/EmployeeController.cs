using Business.Abstract;
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
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) {
            _employeeService = employeeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            var result= _employeeService.GetAll();
            return Ok(result.Data);
        }
    }
}
