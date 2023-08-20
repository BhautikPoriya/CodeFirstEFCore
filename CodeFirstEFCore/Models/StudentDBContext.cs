using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore.Models
{
    public class StudentDBContext : DbContext 
    {
        public StudentDBContext(DbContextOptions options) : base(options) 
        {
            
        }

        //this is will be table name of our database
        public DbSet<Student> Students { get; set; }

    }
}
