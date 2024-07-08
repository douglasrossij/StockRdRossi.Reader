using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table
            builder.ToTable("Users");

            //Identity
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //Properties
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasColumnName("Username")
                .HasColumnType("VARCHAR")
                .HasMaxLength(25);
            
            builder.Property(u => u.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnType("VARCHAR")
                .HasMaxLength(25);

            builder.Property(u => u.IsAdministrator)
                .IsRequired()
                .HasColumnName("IsAdministrator")
                .HasColumnType("BIT");
        }
    }
}