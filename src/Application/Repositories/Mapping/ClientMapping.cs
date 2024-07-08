using Domain.Shared.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Repositories.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            //Table
            builder.ToTable("Clients");

            //Identity
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //Properties
            builder.Property(c=>c.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);
            
            builder.Property(c=>c.Address)
                .IsRequired()
                .HasColumnName("Address")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);
        }
    }
}