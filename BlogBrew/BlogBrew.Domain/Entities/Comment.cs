namespace BlogBrew.Domain.Entities;

public class Comment
{
    public int Id { get; set; }

    public required string UserName { get; set; }

    public DateTime CommentDate { get; set; } = DateTime.UtcNow;

    public required string Content { get; set; }

    public int PostId { get; set; }

    public required Post Post { get; set; }
}
