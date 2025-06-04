namespace BlogBrew.Domain.Entities;

public class Post
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Content { get; set; }

    public required string Author { get; set; }

    public string? ImagePath { get; set; }

    public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

    public int? CategoryId { get; set; }

    public Category? Category { get; set; }

    public ICollection<Comment> Comments { get; set; } = [];
}
