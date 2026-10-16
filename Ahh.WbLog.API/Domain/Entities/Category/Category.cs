using System.ComponentModel.DataAnnotations;

namespace Ahh.WbLog.API.Domain.Entities.Category;

public class Category
{
    public int Id { get; set; }
    [MaxLength(255)]
    public required string Name { get; set; }

    public ICollection<Article.Article> Articles { get; set; }
    = new List<Article.Article>();
}