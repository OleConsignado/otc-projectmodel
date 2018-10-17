﻿using Otc.ComponentModel.DataAnnotations;
using System;

namespace Opala.Web.ViewModels
{
    public abstract class PaymentViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorKey = "400.001")]
        public Guid ClientId { get; set; }

        [Required(ErrorKey = "400.002")]
        public Guid SubscriptionId { get; set; }

        public DateTimeOffset PaidDate { get; set; }

        public DateTimeOffset ExpireDate { get; set; }

        [Required(ErrorKey = "400.003")]
        public decimal Total { get; set; }

        [Required(ErrorKey = "400.004")]
        public decimal TotalPaid { get; set; }

        [Required(ErrorKey = "400.005")]
        public string Payer { get; set; }
    }
}