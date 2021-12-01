using Microsoft.EntityFrameworkCore;

namespace BulkyBooks.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories{ get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite(@"Data Source=C:\Users\1989deny\source\repos\BulkyBooks\BulkyBooks\Database\Books.db");
    }
}
