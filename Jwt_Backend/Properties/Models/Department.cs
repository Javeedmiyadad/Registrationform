using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Api_project.Properties.Models
{
    public class Department
    {
         [Key]
        public int id {get;set;}

        public string code {get;set;}

        public string deptName {get;set;}

        public List<Designation> designation {get;set;}
    }
}