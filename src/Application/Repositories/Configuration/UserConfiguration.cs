using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User> 
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder.Property(u => u.UserName)
                .HasColumnName("user_name")
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(u => u.Password)
                .HasColumnName("password")
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength (100);

            builder.Property(u => u.IsAdministrator)
                .HasColumnName("is_administrator")
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}