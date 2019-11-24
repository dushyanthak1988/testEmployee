using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Employee.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Department { get; set; }

    }
}