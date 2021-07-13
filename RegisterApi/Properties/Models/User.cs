using System.ComponentModel.DataAnnotations;

namespace RegisterApi.Properties.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        public string DOJ { get; set; }
        [Required]
        public int Age { get; set; }

         public int departmentsid {get; set;}

         public int designationdesId {get; set;}
       
        public Departments departments { get; set; }

        public Designation designation { get; set; }
    }
}