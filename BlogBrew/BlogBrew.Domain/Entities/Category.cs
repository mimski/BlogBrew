namespace BlogBrew.Domain.Entities;

public class Category
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Post> Posts { get; set; } = [];
}
