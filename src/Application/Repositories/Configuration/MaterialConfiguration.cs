using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Configuration
{
   public class MaterialConfiguration : IEntityTypeConfiguration<Material> 
   {
        public void Configure(EntityTypeBuilder<Material> builder) 
        {
            builder.ToTable("materials");

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder.Property(m => m.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(m => m.Type)
                .HasColumnName("type")
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(m => m.Notify)
                .HasColumnName("notify")
                .HasColumnType("boolean");

            builder.Property(m => m.MinimumAmount)
                .HasColumnName("minimum_amount")
                .HasColumnType("decimal(18, 2)");

            builder.Property(m => m.CurrentAmount)
                .HasColumnName("current_amount")
                .IsRequired()
                .HasColumnType("decimal(18, 2)");
        }
   }
}