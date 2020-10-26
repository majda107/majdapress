using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class ArticlesView
    {
        [Key] public int Id { get; set; }
        public List<ArticleTag> VisibleTags { get; set; }
    }
}