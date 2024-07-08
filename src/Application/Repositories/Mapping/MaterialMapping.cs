using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Mapping
{
    public class MaterialMapping : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            //Table
            builder.ToTable("Materials");

            //Identity
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //Properties
            builder.Property(u => u.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);
            
            builder.Property(u => u.Type)
                .IsRequired()
                .HasColumnName("MaterialType")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.Property(u => u.Notify)
                .IsRequired()
                .HasColumnName("Notify")
                .HasColumnType("BIT");

            builder.Property(u => u.MinimumAmount)
                .IsRequired()
                .HasColumnName("MinimumAmount")
                .HasColumnType("DECIMAL")
                .HasPrecision(20, 2);

            builder.Property(u => u.CurrentAmount)
                .IsRequired()
                .HasColumnName("CurrentAmount")
                .HasColumnType("DECIMAL")
                .HasPrecision(20, 2);
        }
    }
}