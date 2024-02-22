using Microsoft.EntityFrameworkCore;
using NewStudentWeb.Models;

namespace NewStudentWeb.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> contextOptions): base(contextOptions) 
        {

        }
        // Code Approach
        public DbSet<Student> Students { get; set; }
    }
}
