using ShopOnlineCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ShopOnlineCore.Data.Entities
{
    [Table("Colors")]
    public class Color : DomainEntity<int>
    {

        public string Name
        {
            get; set;
        }

        public string Code { get; set; }
    }
}
