﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.SaleCommands
{
    public class UpdateSaleCommand
    {
        [Required]
        public string SaleId { get; set; }
        [Required]
        public string StoreId { get; set; }

        [Required]
        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime TransaccionTime { get; set; }
    }
}
