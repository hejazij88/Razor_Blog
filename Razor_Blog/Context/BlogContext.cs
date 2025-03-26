using Microsoft.EntityFrameworkCore;
using Razor_Blog.Model;

namespace Razor_Blog.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> option) : base(option)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
