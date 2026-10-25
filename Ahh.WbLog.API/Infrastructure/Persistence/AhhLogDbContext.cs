using Ahh.WbLog.API.Domain.Entities.Article;
using Ahh.WbLog.API.Domain.Entities.Category;
using Ahh.WbLog.API.Domain.Entities.Comment;
using Microsoft.EntityFrameworkCore;

namespace Ahh.WbLog.API.Infrastructure.Persistence
{
    public sealed class AhhLogDbContext(DbContextOptions<AhhLogDbContext> options) : DbContext(options)
    {
        public DbSet<Article> Articles => Set<Article>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Comment> Comments => Set<Comment>();
    }
}