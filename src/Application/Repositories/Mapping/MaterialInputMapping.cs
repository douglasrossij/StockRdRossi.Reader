using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Mapping
{
    public class MaterialInputMapping : IEntityTypeConfiguration<MaterialInput>
    {
        public void Configure(EntityTypeBuilder<MaterialInput> builder)
        {
            //Table
            builder.ToTable("MaterialInput");

            //Identity
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn().ValueGeneratedOnAddOrUpdate();

            //Properties
            builder.Property(m => m.InputDate)
                   .IsRequired()
                   .HasColumnName("InputDate")
                   .HasColumnType("DATE");

            builder.Property(m => m.Amount)
                   .IsRequired()
                   .HasColumnName("Amount")
                   .HasColumnType("decimal")
                   .HasPrecision(20, 2);

            //Foreign Keys
            builder.HasOne(m => m.Material);
            builder.HasOne(m => m.Employee);
        }
    }
}