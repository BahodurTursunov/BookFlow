//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace BookFlow.Infrastructure.Configurations
//{
//    public class BookConfiguration : IEntityTypeConfiguration<Book>
//    {
//        public void Configure(EntityTypeBuilder<Book> builder)
//        {
//            builder.HasKey(pk => pk.Id);

//            builder
//                .HasMany(b => b.Authors)
//                .WithMany(b => b.Books)
//                .UsingEntity(en => en.ToTable("BookAuthor"));
//        }
//    }
//}
