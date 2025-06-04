using BlogBrew.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogBrew.Infrastructure;

public class BlogBrewDbContext : DbContext
{
    public BlogBrewDbContext(DbContextOptions<BlogBrewDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogBrewDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
