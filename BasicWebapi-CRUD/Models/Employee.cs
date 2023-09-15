using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicWebapi_CRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string EmployeeName { get; set; } = "";
        public int PhoneNumber { get; set; }
        public int Age { get; set; }

    }
}
