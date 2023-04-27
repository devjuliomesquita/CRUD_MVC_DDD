using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infrastruture.Data.EntityConfig
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);
            builder
                .Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(150);
            builder
                .Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(150);
            builder
                .Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .HasMany(c => c.Products)
                .WithOne()
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
