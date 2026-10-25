using System.ComponentModel.DataAnnotations;
using Ahh.WbLog.API.Domain.Enums.Comment;

namespace Ahh.WbLog.API.Domain.Entities.Comment;

public class Comment
{
   public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string AuthorName { get; set; }

    [Required]
    public required string Content { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset? UpdatedAt { get; set; }

    public int ArticleId { get; set; }

    public Article.Article Article { get; set; } = null!;

    public CommentStatus Status { get; set; } = CommentStatus.Pending;
}