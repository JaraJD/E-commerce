﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string StoreId { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
