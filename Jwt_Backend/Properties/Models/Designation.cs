using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Designation
    {
         [Key]
        public int desId {get;set;}

        public string name {get;set;}

        public int departmentsid {get;set;}

        public Department departments {get;set;}
    }
}