using Microsoft.EntityFrameworkCore;

namespace RegisterApi.Properties.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions options) : base(options){}

        public DbSet<User> Users {get;set;}

        public DbSet<Departments> department {get;set;}
        
        public DbSet<Designation> designation {get;set;}

        
    }
}