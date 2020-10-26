using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class ProductCart
    {
        [Key] public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}