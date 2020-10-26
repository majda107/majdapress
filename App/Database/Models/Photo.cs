using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Photo
    {
        [Key] public int Id { get; set; }

        public string Filename { get; set; }
        public string Description { get; set; }
    }
}