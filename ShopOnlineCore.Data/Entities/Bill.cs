﻿using ShopOnlineCore.Data.Enums;
using ShopOnlineCore.Infrastructure.Enums;
using ShopOnlineCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ShopOnlineCore.Data.Interfaces;

namespace ShopOnlineCore.Data.Entities
{
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill() { }

        public Bill(string customerName, string customerAddress, string customerMobile, string customerMessage,
            BillStatus billStatus, PaymentMethod paymentMethod, Status status, Guid? customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        public Bill(int id, string customerName, string customerAddress, string customerMobile, string customerMessage,
           BillStatus billStatus, PaymentMethod paymentMethod, Status status, Guid? customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        [Required]
        public string CustomerName { set; get; }

        [Required]
        public string CustomerAddress { set; get; }

        [Required]
        public string CustomerMobile { set; get; }

        [Required]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; } = Status.;

        public Guid? CustomerId { set; get; }

        [ForeignKey("CustomerId")]
        public virtual AppUser User { set; get; }

        public virtual ICollection<BillDetail> BillDetails { set; get; }
    }
}
