using ShopOnlineCore.Data.Enums;
using ShopOnlineCore.Data.Interfaces;
using ShopOnlineCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopOnlineCore.Data.Entities
{
    [Table("Advertistments")]
    public class Advertistment: DomainEntity<int>, ISwitchable, ISortable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string PositionId { get; set; }
        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }
        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
