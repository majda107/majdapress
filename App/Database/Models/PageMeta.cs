using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class PageMeta
    {
        [Key] public int Id { get; set; }
        public string HtmlHead { get; set; }
    }
}