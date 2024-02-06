using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Infrastructure.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Post>()
                .HasData(
                new Post() {Id =1, Title ="Post1", Content ="Random post1"},
                new Post() { Id = 2, Title = "Post2", Content = "Random post2" },
                new Post() { Id = 3, Title = "Post3", Content = "Random post3" });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Post> Posts { get; set; }

    }
}
