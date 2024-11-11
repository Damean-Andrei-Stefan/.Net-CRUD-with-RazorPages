using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Damean_Andrei_Stefan_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name= "Book Title")]
        [StringLength(150, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public int? AuthorID   { get; set; }
        [Display(Name = "Author")]
        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
