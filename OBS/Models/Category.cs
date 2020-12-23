using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OBS.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}