using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDemo.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 2)]
        public string Author { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [StringLength(25, MinimumLength = 2)]
        public string ISBN { get; set; }
    }
}