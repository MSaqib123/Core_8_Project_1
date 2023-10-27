using Implement_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Implement_Project.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
