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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.ProductId);
            builder
                .Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(250);
            builder
                .Property(p => p.ProductValue)
                .IsRequired();
            builder
                .Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50);
            

        }
    }
}
