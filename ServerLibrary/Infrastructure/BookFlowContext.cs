using BaseLibrary.Models;
using BookFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookFlow.Infrastructure
{
    public class BookFlowContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SystemRole> SystemRoles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }

        public BookFlowContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(k => new { k.AuthorId, k.BookId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(fk => fk.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(fk => fk.AuthorId);


            modelBuilder.Entity<Category>()
                .HasKey(pk => pk.Id);

            modelBuilder.Entity<Category>()
                .HasMany(b => b.Books)
                .WithOne(c => c.Category)
                .HasForeignKey(fk => fk.CategoryId);

        }
    }
}
