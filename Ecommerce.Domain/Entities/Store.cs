﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Store
    {
        public string StoreId { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public bool IsDeleted { get; set; }
    }
}
