using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;

namespace Data.Configuration
{
    public class ProductOrderDetailConfiguration : IEntityTypeConfiguration<ProductOrderDetail>
    {
        public void Configure(EntityTypeBuilder<ProductOrderDetail> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.Id });
            builder.ToTable("ProductOrderDetail");
            builder.HasOne(x => x.Product).WithMany(pd => pd.ProductOrderDetail)
                .HasForeignKey(pd => pd.ProductId);
            builder.HasOne(x => x.OrderDetail).WithMany(pd => pd.ProductOrderDetail)
                .HasForeignKey(pd => pd.Id);
        }
    }
}
