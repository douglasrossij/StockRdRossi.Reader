using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Configuration
{
    internal class MaterialOutputConfiguration : IEntityTypeConfiguration<MaterialOutput>
    {
        public void Configure(EntityTypeBuilder<MaterialOutput> builder)
        {
            //Table
            builder.ToTable("MaterialOutput");

            //Identity
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();

            //Properties
            builder.Property(m => m.OutputDate)
                   .IsRequired()
                   .HasColumnName("OutputDate")
                   .HasColumnType("DATE");

            builder.Property(m => m.Amount)
                   .IsRequired()
                   .HasColumnName("Amount")
                   .HasColumnType("decimal")
                   .HasPrecision(20, 2);

            //Foreign Keys
            builder.HasOne(m => m.Material);
            builder.HasOne(m => m.Employee);
            builder.HasOne(m => m.Client);
        }
    }
}