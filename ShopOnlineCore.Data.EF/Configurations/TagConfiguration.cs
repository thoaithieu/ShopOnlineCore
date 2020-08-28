using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineCore.Data.EF.Extensions;
using ShopOnlineCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnlineCore.Data.EF.Configurations
{
    class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().HasColumnType("varchar(50)");
        }
    }
}
