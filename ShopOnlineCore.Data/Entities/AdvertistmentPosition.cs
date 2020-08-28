using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopOnlineCore.Data.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition
    {
        public string PageId { get; set; }
        public string Name { get; set; }
        [ForeignKey("PageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }
        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
