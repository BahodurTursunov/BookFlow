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
            /*            modelBuilder.Entity<BookAuthor>()
                    .HasKey(ba => new { ba.BookId, ba.AuthorId });

                        modelBuilder.Entity<BookAuthor>()
                            .HasOne(ba => ba.Book)
                            .WithMany(b => b.BookAuthors)
                            .HasForeignKey(ba => ba.BookId);

                        modelBuilder.Entity<BookAuthor>()
                            .HasOne(ba => ba.Author)
                            .WithMany(a => a.BookAuthors)
                            .HasForeignKey(ba => ba.AuthorId);

                        modelBuilder
                        .Entity<Book>()
                        .HasMany(c => c.Authors)
                        .WithMany(s => s.Books)
                        .UsingEntity<BookAuthor>(
                        j => j.HasOne(pt => pt.Book)
                            .WithMany(t => t.BookAuthors)
                            .HasForeignKey(pt => pt.BookId),
                        j => j
                            .HasOne(pt => pt.Author)
                            .WithMany(p => p.BookAuthors)
                            .HasForeignKey(pt => pt.AuthorId),
                        j =>
                        {
                            j.HasKey(t => new { t.BookId, t.AuthorId });
                            j.ToTable("BookAuthors");
                        });*/

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Book>()
            .HasMany(c => c.Authors)
            .WithOne(c => c.Book)
            .HasForeignKey(fk => fk.BookId);

            //modelBuilder.Entity<Author>()
            //    .HasOne(b => b.Authors)
            //    .WithOne(b => b.Author)
            //    .HasForeignKey(fk => fk.AuthorId);

            modelBuilder.Entity<Category>()
                .HasKey(pk => pk.Id);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Books)
                .WithOne(p => p.Category)
                .HasForeignKey(fk => fk.CategoryId);

            /*modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(fk => fk.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);*/
        }
    }
}
