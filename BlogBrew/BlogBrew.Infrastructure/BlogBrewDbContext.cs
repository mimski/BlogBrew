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

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Technology" },
            new Category { Id = 2, Name = "Health" },
            new Category { Id = 3, Name = "LifeStyle" }
        );

        modelBuilder.Entity<Post>().HasData(
            new Post
            { 
                Id = 1,
                Title = "Tech Post",
                Content = "Content of Tech Post",
                Author = "John Doe",
                PublishedDate = new DateTime(2025, 4, 25),
                ImagePath = "tech.jpg",
                CategoryId = 1,
            },
            new Post
            {
                Id = 2,
                Title = "Health Post",
                Content = "Content of Health Post",
                Author = "Jane Doe",
                PublishedDate = new DateTime(2025, 1, 1),
                ImagePath = "health.jpg",
                CategoryId = 2,
            },
            new Post
            {
                Id = 3,
                Title = "Lifestyle Post",
                Content = "Content of Lifestyle Post",
                Author = "Jane Doe",
                PublishedDate = new DateTime(2025, 12, 24),
                ImagePath = "lifestyle.jpg",
                CategoryId = 3,
            }
        );
    }
}
