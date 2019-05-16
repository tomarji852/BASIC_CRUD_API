using System.ComponentModel.DataAnnotations;

namespace HelperProject
{
    public class Employee
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Salary { get; set; }
    }
}
