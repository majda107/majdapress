using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class View
    {
        [Key] public int Id { get; set; }

        public string ViewType { get; set; }
    }
}