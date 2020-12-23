using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OBS.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; set; }

        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public ICollection<byte> CategoriesId { get; set; }

        // Navigation Properties
        public BookInfo BookInfo { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}