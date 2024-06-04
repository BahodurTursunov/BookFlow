using BookFlow.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookFlow.Infrastructure
{
    public class BookFlowContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookAuthor> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public BookFlowContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
