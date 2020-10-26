using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class TextContent
    {
        [Key] public int Id { get; set; }
        public string HtmlText { get; set; }
    }
}