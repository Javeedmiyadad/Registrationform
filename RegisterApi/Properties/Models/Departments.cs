using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegisterApi.Properties.Models
{
    public class Departments
    {
        [Key]
        public int id {get;set;}

        public string code {get;set;}

        public string deptName {get;set;}

        public List<Designation> designation {get;set;}
    }
}