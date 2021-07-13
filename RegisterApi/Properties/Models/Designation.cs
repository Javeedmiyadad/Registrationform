using System.ComponentModel.DataAnnotations;

namespace RegisterApi.Properties.Models
{
    public class Designation
    {
        [Key]
        public int desId {get;set;}

        public string name {get;set;}

        public int departmentsid {get;set;}

        public Departments departments {get;set;}
    }
}