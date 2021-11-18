using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class PdInOrderDetailConfiguration : IEntityTypeConfiguration<PdInOrderDetail>
    {
        public void Configure(EntityTypeBuilder<PdInOrderDetail> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.Id });
            builder.ToTable("ProductDetail");
            builder.HasOne(x => x.Product).WithMany(pd => pd.PdInOrderDetail)
                .HasForeignKey(pd => pd.ProductId);
            builder.HasOne(x => x.OrderDetail).WithMany(pd => pd.PdInOrderDetail)
                .HasForeignKey(pd => pd.Id);
        }
    }
}
