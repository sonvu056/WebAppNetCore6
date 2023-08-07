using System.ComponentModel.DataAnnotations;

namespace WebAppNetCore6.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
