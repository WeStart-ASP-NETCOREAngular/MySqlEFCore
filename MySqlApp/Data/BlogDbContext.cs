using Microsoft.EntityFrameworkCore;
using MySqlApp.Models;

namespace MySqlApp.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Valerio De Sanctis" },
                new Author { Id = 2, Name = "Adam Freeman" }
                );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}
