using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class ArticleComment
    {
        [Key] public int Id { get; set; }

        public string Text { get; set; }
    }
}