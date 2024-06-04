//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace BookFlow.Infrastructure.Configurations
//{
//    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//    {
//        public void Configure(EntityTypeBuilder<Category> builder)
//        {
//            builder
//                .HasKey(pk => pk.Id);

//            //builder
//            //    .HasMany(c => c.Books)
//            //    .WithMany(c => c.Categories)
//            //    .UsingEntity(en => en.ToTable("BookCategory"));
//            builder
//                .HasMany(b => b.Authors)
//                .WithMany(a => a.Books);
//        }
//    }
//}
