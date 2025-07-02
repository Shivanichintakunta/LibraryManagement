using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public String? Email { get; set; }
    }
}
