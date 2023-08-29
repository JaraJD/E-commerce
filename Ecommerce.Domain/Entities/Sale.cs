﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Sale
    {
        public string SaleId { get; set; }
        [Required]
        public string StoreId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public List<Product> products { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime TransaccionTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
