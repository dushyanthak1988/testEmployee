using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test_Employee.Models;

namespace Test_Employee.Controllers
{
    public class DepartmentController : Controller
    { 
        public ActionResult Index()
        {
            EmployeeContext _employeeContext = new EmployeeContext();
            List<Department> _Departments=  _employeeContext._Departments.ToList(); 
            return View(_Departments);
        }
    }
}