using Microsoft.EntityFrameworkCore;

namespace BasicWebapi_CRUD.Models
{
    public class APIDbcontext : DbContext
    {
        public APIDbcontext(DbContextOptions option):base(option) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
