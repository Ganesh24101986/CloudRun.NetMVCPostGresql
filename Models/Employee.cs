using System.ComponentModel.DataAnnotations;

namespace DotNetCoerMVCProjectCloudRUN.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }
    }
}
