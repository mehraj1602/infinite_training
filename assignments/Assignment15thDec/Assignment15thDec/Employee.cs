using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15thDec
{
   public class Employee
    {
        [Key]
        [Required(ErrorMessage = "EmpId is required")]
        [RegularExpression(@"^E\d{3}$",
        ErrorMessage = "EmpId must start with 'E' followed by 3 digits (Eg: E101)")]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string EmpId { get; set; }
        [Required(ErrorMessage = "Employee Name is required")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string DepartmentName { get; set; }
        [Range(5000, 50000, ErrorMessage = "Salary must be between 5000 and 50000")]
        public int Salary { get; set; }
        [Range(1990, int.MaxValue,
        ErrorMessage = "Year of Joining must be 1990 or later")]
        public int YearOfJoining { get; set; }
    }
}
