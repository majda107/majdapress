using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Page
    {
        [Key] public int Id { get; set; }

        public string Url { get; set; }
        public string Name { get; set; }
        public PageTemplate TemplateId { get; set; }
        public List<PageMeta> Metas { get; set; }
        public PageStats Stats { get; set; }
        public List<View> Views { get; set; }
    }
}