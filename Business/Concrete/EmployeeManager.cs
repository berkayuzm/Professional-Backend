using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal; 
        }
        public IResult Add(Employee employee)
        {
         _employeeDal.Add(employee);
         return new SuccessResult("Employee ekleme işlemi başarılı");
        }

        public IDataResult<List<Employee>> GetAll()
        {
           var data = _employeeDal.GetAll();
           return new SuccessDataResult<List<Employee>>(data,"sorgulama başarılı");
        }

        public IDataResult<Employee> GetById(int id)
        {
            var data = _employeeDal.Get(e=>e.EmployeeId==id);
            return new SuccessDataResult<Employee>(data, "sorgulama başarılı");
        }
    }
}
