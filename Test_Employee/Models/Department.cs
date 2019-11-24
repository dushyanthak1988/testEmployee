using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Employee.Models
{
    [Table ("usrDepartment")]
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}