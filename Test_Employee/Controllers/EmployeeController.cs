using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test_Employee.Models;

namespace Test_Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index( int DepartmentID)
        {
            EmployeeContext _EmployeeContext = new EmployeeContext();
            List<Employee> _EmployeeS = _EmployeeContext._Employees.Where(Emp => Emp.Department == DepartmentID ).ToList();
            return View(_EmployeeS);
        }


        public ActionResult Details( int ID )
        {
            EmployeeContext _EmployeeContext = new EmployeeContext();
            Employee _Employee = _EmployeeContext._Employees.Single(Empl => Empl.EmployeeID == ID);

            return View(_Employee);
        }
    }
}