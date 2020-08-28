using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineCore.Data.EF.Extensions;
using ShopOnlineCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnlineCore.Data.EF.Configurations
{
    public class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
