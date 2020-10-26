using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Gallery
    {
        [Key] public int Id { get; set; }
        public List<Photo> Photos { get; set; }
    }
}