using ShopOnlineCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopOnlineCore.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>
    {
        [Required]
        public string Name { set; get; }

        
        public string Description { set; get; }

        
        [Required]
        public string Image { set; get; }

        
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }

        public string Content { set; get; }

       
        [Required]
        public string GroupAlias { get; set; }
    }
}
