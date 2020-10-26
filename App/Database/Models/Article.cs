using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Article
    {
        [Key] public int Id { get; set; }

        public List<ArticleComment> Comments { get; set; }
        public List<ArticleTag> Tags { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Perex { get; set; }
        public List<Content> Content { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }
}