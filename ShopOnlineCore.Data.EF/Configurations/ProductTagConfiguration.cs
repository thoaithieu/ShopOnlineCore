using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineCore.Data.EF.Extensions;
using ShopOnlineCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnlineCore.Data.EF.Configurations
{
    class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(255).IsRequired()
            .HasColumnType("varchar(255)");
            // etc.
        }
    }
}
