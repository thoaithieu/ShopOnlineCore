using ShopOnlineCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopOnlineCore.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        
        [Required]
        public string Name { get; set; }

        
        [Required]
        public string Type { get; set; }
    }
}