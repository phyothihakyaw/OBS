using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OBS.Models
{
    public class BookInfo
    {
        [ForeignKey("Book")]
        public int Id { get; set; }

        [Required]
        public byte[] Cover { get; set; }

        [Required]
        public byte[] File { get; set; }

        // Navigaion property
        public Book Book { get; set; }
    }
}