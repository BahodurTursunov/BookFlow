//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace BookFlow.Infrastructure.Configurations
//{
//    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
//    {
//        public void Configure(EntityTypeBuilder<BookAuthor> builder)
//        {
//            builder
//                .HasKey(ba => new { ba.BookId, ba.AuthorId });

//            builder
//                .HasOne(b => b.Book)
//                .WithMany(ba => ba.BookAuthors)
//                .HasForeignKey(fk => fk.BookId)
//                .IsRequired(false);

//            builder
//                .HasOne(b => b.Author)
//                .WithMany(ba => ba.BookAuthors)
//                .HasForeignKey(fk => fk.AuthorId)
//                .IsRequired(false);

//        }
//    }
//}
