using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Product
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }
        public float Price { get; set; }
        public Photo Photo { get; set; }
        public ProductTag Tag { get; set; }
    }
}