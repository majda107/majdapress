using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class DomainMenu
    {
        [Key] public int Id { get; set; }
        public List<MenuItem> MenuItem { get; set; }
    }
}