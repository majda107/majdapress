using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class ImageContent
    {
        [Key] public int Id { get; set; }
        public Photo Photo { get; set; }
    }
}