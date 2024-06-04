//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace BookFlow.Infrastructure.Configurations
//{
//    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
//    {
//        public void Configure(EntityTypeBuilder<BookCategory> builder)
//        {
//            builder.HasKey(pk => pk.Id);

//            builder.HasKey(bc => new { bc.BookId, bc.CategoryId });

//            //builder
//            //    .HasOne(bc => bc.Book)
//            //    .WithMany(b => b.BookCategories)
//            //    .HasForeignKey(bc => bc.BookId);

//            //builder
//            //    .HasOne(bc => bc.Category)
//            //    .WithMany(c => c.BookCategories)
//            //    .HasForeignKey(bc => bc.CategoryId);
//        }
//    }
//}
