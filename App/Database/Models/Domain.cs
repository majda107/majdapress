using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class Domain
    {
        [Key] public int Id { get; set; }

        public List<Page> Pages { get; set; }
        public Gallery Gallery { get; set; }
        public List<Product> Products { get; set; }
        public DomainMenu Menu { get; set; }
        public List<Article> Articles { get; set; }
    }
}