using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace WebApiDay3.Models
{
    public class myDBcontext :DbContext
    {
        public myDBcontext()
        {

        }
        public myDBcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
