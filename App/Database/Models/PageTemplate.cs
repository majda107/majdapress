using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class PageTemplate
    {
        [Key] public int Id { get; set; }
        public string HtmlTemplate { get; set; }
    }
}