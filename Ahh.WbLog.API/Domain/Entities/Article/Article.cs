using System.ComponentModel.DataAnnotations;
using Ahh.WbLog.API.Domain.Enums.Article;

namespace Ahh.WbLog.API.Domain.Entities.Article;

public class Article
{
    public int Id { get; set; }

    [MaxLength(255)]
    public required string Title { get; set; }

    public required string Content { get; set; }

    public Status Status { get; set; } = Status.Draft;

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }

    public DateTimeOffset? PublishedAt { get; set; }

    public int? CategoryId { get; set; }

    public Category.Category? Category { get; set; }

    public ICollection<Comment.Comment> Comments { get; set; }
        = new List<Comment.Comment>();
}