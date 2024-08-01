using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Configuration
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            //Table
            builder.ToTable("Materials");

            //Identity
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //Properties
            builder.Property(m => m.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);
            
            builder.Property(m => m.Type)
                .IsRequired()
                .HasColumnName("MaterialType")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.Property(m => m.Notify)
                .IsRequired()
                .HasColumnName("Notify")
                .HasColumnType("BIT");

            builder.Property(m => m.MinimumAmount)
                .IsRequired()
                .HasColumnName("MinimumAmount")
                .HasColumnType("DECIMAL")
                .HasPrecision(20, 2);

            builder.Property(m => m.CurrentAmount)
                .IsRequired()
                .HasColumnName("CurrentAmount")
                .HasColumnType("DECIMAL")
                .HasPrecision(20, 2);
        }
    }
}