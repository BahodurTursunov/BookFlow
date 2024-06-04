using BookFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookFlow.Infrastructure
{
    public class BookFlowContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public BookFlowContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder
                        .Entity<Book>()
                        .HasMany(b => b.Authors)
                        .WithMany(a => a.Books); // Связь "многие ко многим" между Author и Book

            modelBuilder
                        .Entity<Book>()
                        .HasMany(b => b.Categories)
                        .WithMany(c => c.Books);
        }
    }
}
