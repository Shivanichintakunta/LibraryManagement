using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagement
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int YearPublished { get; set; }
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

        public Author? Author { get; set; }

    }
}
