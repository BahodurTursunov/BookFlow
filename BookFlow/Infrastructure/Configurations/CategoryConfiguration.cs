//using BookFlow.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//{
//    public void Configure(EntityTypeBuilder<Category> builder)
//    {
//        builder.HasKey(b => b.Id);

//        builder
//            .HasMany(c => c.Books)
//            .WithOne(c => c.Category)
//            .HasForeignKey(fk => fk.CategoryId);
//    }
//}