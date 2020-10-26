using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class PageStats
    {
        [Key] public int Id { get; set; }

        public int Visitors { get; set; }
    }
}