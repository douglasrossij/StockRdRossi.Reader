using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Table
            builder.ToTable("Employees");

            //Identity
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //Properties
            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);
        }
    }
}