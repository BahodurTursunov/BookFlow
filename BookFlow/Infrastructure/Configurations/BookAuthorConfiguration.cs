//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace BookFlow.Infrastructure.Configurations
//{
//    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
//    {
//        public void Configure(EntityTypeBuilder<BookAuthor> builder)
//        {
//            builder.HasKey(fk => new { fk.BookId, fk.AuthorId });

//            builder
//                .HasOne(ba => ba.Auhor)
//                .WithMany(b => b.Books)
//                .HasForeignKey(fk => fk.BookId)
//                .HasForeignKey(fk => fk.AuthorId);


//        }
//    }
//}
