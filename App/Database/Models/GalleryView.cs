using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class GalleryView
    {
        [Key] public int Id { get; set; }
        public Gallery Gallery { get; set; }
    }
}