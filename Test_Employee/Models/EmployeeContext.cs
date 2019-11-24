using System.Data.Entity;

namespace Test_Employee.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> _Employees { get; set; }
        public DbSet<Department> _Departments { get; set; }

    }
}