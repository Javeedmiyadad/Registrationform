using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Register
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string DOJ { get; set; }
        [Required]
        public int Age { get; set; }

        public int departmentsid { get; set; }

        public int designationdesId { get; set; }

        public Department departments { get; set; }

        public Designation designation { get; set; }
    }
}