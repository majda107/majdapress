using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class ArticleTag
    {
        [Key] public int Id { get; set; }
        public string Tag { get; set; }
    }
}